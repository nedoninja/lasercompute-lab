from PyQt6.QtWidgets import *
from PyQt6.QtCore import *
from PyQt6.QtGui import *
import serial


class DebugIOConsole(QDialog):
    def __init__(self, parent, serial_port):
        super().__init__(parent)
        self.serial_port = serial_port
        self.init_ui()

    def init_ui(self):
        self.setWindowTitle("Отладка через I/O консоль устройства")
        self.setFixedSize(800, 450)

        layout = QVBoxLayout()

        self.console_text = QTextEdit()
        self.console_text.setReadOnly(True)
        layout.addWidget(self.console_text)

        input_layout = QHBoxLayout()
        self.data_input = QLineEdit()
        self.data_input.setPlaceholderText("Введите данные для отправки")
        self.data_input.returnPressed.connect(self.send_data)
        input_layout.addWidget(self.data_input)

        self.send_button = QPushButton("Отправить")
        self.send_button.clicked.connect(self.send_data)
        input_layout.addWidget(self.send_button)

        self.clear_button = QPushButton("Очистить")
        self.clear_button.clicked.connect(self.console_text.clear)
        input_layout.addWidget(self.clear_button)

        layout.addLayout(input_layout)
        self.setLayout(layout)

    def send_data(self):
        if self.serial_port and self.serial_port.is_open:
            try:
                data = self.data_input.text()
                self.serial_port.write(data.encode('ascii'))
                self.data_input.clear()
            except Exception as e:
                QMessageBox.critical(self, "Ошибка", f"Не удалось отправить данные: {str(e)}")