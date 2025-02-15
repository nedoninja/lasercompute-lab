from PyQt6.QtWidgets import *
from PyQt6.QtCore import *
from PyQt6.QtGui import *
from com_manager import ComManager
from serial_thread import SerialThread


class LaserComputeLab(QMainWindow):
    def __init__(self):
        super().__init__()
        self.serial_port = None
        self.databuffer = ""
        self.mode = 0
        self.init_ui()
        self.start_serial_thread()

    def init_ui(self):
        self.setWindowTitle("Laser Compute Lab v1.0")
        self.setMinimumSize(1036, 665)

        toolbar = QToolBar()
        self.addToolBar(Qt.ToolBarArea.TopToolBarArea, toolbar)

        self.run_button = QAction("Запуск вычисления", self)
        toolbar.addAction(self.run_button)

        tools_menu = QToolButton()
        tools_menu.setText("Инструменты")
        tools_menu.setPopupMode(QToolButton.ToolButtonPopupMode.InstantPopup)

        menu = QMenu()
        self.com_manager_action = QAction("Менеджер подключений COM", self)
        self.com_manager_action.triggered.connect(self.show_com_manager)

        self.debug_action = QAction("Отладчик", self)
        self.debug_action.setCheckable(True)
        self.debug_action.toggled.connect(self.toggle_debug)

        menu.addAction(self.com_manager_action)
        menu.addAction(self.debug_action)
        tools_menu.setMenu(menu)
        toolbar.addWidget(tools_menu)

        toolbar.addSeparator()
        self.connected_status = QLabel("Не подключено")
        toolbar.addWidget(self.connected_status)

        splitter = QSplitter()

        self.lab_list = QListWidget()
        self.lab_list.addItems(["Стартовый экран", "1-разрядный сумматор"])
        self.lab_list.currentRowChanged.connect(self.switch_panel)
        splitter.addWidget(self.lab_list)

        self.main_panel = QStackedWidget()
        self.create_base_panel()
        self.create_lab1_panel()
        splitter.addWidget(self.main_panel)

        self.setCentralWidget(splitter)

    def create_base_panel(self):
        panel = QWidget()
        layout = QVBoxLayout()

        title = QLabel("Laser Compute Lab v1.0")
        title.setFont(QFont("Arial", 14, QFont.Weight.Bold))
        layout.addWidget(title)

        desc = QLabel(
            "Программа выполнения лабораторных опытов и тестирования\n"
            "вычислительных систем на лазерах.\n\n"
            "Авторы научной работы:\n"
            "Горлов Тимофей\n"
            "Семенов Святослав\n"
            "Лангас Владислав"
        )
        desc.setFont(QFont("Arial", 12))
        layout.addWidget(desc)

        panel.setLayout(layout)
        self.main_panel.addWidget(panel)

    def create_lab1_panel(self):
        panel = QWidget()
        layout = QVBoxLayout()

        input_group = QGroupBox("Вводимые данные")
        input_layout = QFormLayout()

        self.num_a = QSpinBox()
        self.num_a.setMaximum(1)
        self.num_b = QSpinBox()
        self.num_b.setMaximum(1)

        input_layout.addRow("Цифра A:", self.num_a)
        input_layout.addRow("Цифра B:", self.num_b)
        input_group.setLayout(input_layout)

        pred_group = QGroupBox("Прогнозирование")
        pred_layout = QFormLayout()

        self.result_prob = QLineEdit()
        self.result_prob.setReadOnly(True)
        self.accuracy = QLineEdit()
        self.accuracy.setReadOnly(True)
        self.compute_btn = QPushButton("Проверка на точность")

        pred_layout.addRow("Прогнозируемый результат:", self.result_prob)
        pred_layout.addRow("Точность:", self.accuracy)
        pred_layout.addRow(self.compute_btn)
        pred_group.setLayout(pred_layout)

        output_group = QGroupBox("Выходные данные")
        output_layout = QVBoxLayout()
        self.text_box = QLineEdit()
        self.text_box.setReadOnly(True)
        output_layout.addWidget(self.text_box)
        output_group.setLayout(output_layout)

        correct_group = QGroupBox("Коректировка")
        correct_layout = QFormLayout()

        self.floor = QLineEdit()
        self.floor.setReadOnly(True)
        self.roof = QLineEdit()
        self.roof.setReadOnly(True)
        self.correct_btn = QPushButton("Провести корректировку")
        self.correct_btn.clicked.connect(self.send_correction)

        correct_layout.addRow("Пол единицы:", self.floor)
        correct_layout.addRow("Потолок единицы:", self.roof)
        correct_layout.addRow(self.correct_btn)
        correct_group.setLayout(correct_layout)

        self.debug_group = QGroupBox("Debug-информация")
        debug_layout = QVBoxLayout()

        self.debug_output = QTextEdit()
        self.debug_output.setReadOnly(True)
        self.clear_debug_btn = QPushButton("Очистить")
        self.clear_debug_btn.clicked.connect(self.debug_output.clear)

        debug_layout.addWidget(self.debug_output)
        debug_layout.addWidget(self.clear_debug_btn)
        self.debug_group.setLayout(debug_layout)
        self.debug_group.setVisible(False)

        layout.addWidget(input_group)
        layout.addWidget(pred_group)
        layout.addWidget(output_group)  # Выходные данные выше корректировки
        layout.addWidget(correct_group)
        layout.addWidget(self.debug_group)
        panel.setLayout(layout)
        self.main_panel.addWidget(panel)

    def switch_panel(self, index):
        self.main_panel.setCurrentIndex(index)

    def show_com_manager(self):
        dialog = ComManager(self)
        dialog.exec()

    def start_serial_thread(self):
        self.serial_thread = SerialThread(self)
        self.serial_thread.data_received.connect(self.handle_serial_data)
        self.serial_thread.start()

    def send_correction(self):
        if self.serial_port and self.serial_port.is_open:
            try:
                self.serial_port.write(b"!\n")
                self.mode = 1
                self.databuffer = ""
            except Exception as e:
                QMessageBox.critical(self, "Ошибка", f"Ошибка отправки: {str(e)}")
        else:
            QMessageBox.warning(self, "Ошибка", "Порт не подключен")

    def handle_serial_data(self, data):
        self.databuffer += data
        self.debug_output.append(data)

        if self.mode == 1 and "Autocompute [done]" in self.databuffer:
            lines = [line.strip() for line in self.databuffer.split('\n') if line.strip()]
            for line in lines:
                if line.startswith("Floor"):
                    self.floor.setText(line.split()[1])
                elif line.startswith("Roof"):
                    self.roof.setText(line.split()[1])
            self.databuffer = ""

    def toggle_debug(self, checked):
        self.debug_group.setVisible(checked)

    def closeEvent(self, event):
        if self.serial_port and self.serial_port.is_open:
            self.serial_port.close()
        event.accept()