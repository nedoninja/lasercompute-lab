from PyQt6.QtWidgets import *
from PyQt6.QtCore import *
from PyQt6.QtGui import *
import serial
import serial.tools.list_ports


class ComManager(QDialog):
    def __init__(self, parent=None):
        super().__init__(parent)
        self.parent = parent
        self.serial_port = None
        self.init_ui()

    def init_ui(self):
        self.setWindowTitle("Менеджер подключений COM")
        self.setFixedSize(755, 178)

        layout = QVBoxLayout()

        port_layout = QHBoxLayout()
        self.label1 = QLabel("Выберите рабочий порт:")
        self.port_combo = QComboBox()
        self.port_combo.setEnabled(False)
        port_layout.addWidget(self.label1)
        port_layout.addWidget(self.port_combo)

        speed_layout = QHBoxLayout()
        self.label2 = QLabel("Выберите скорость передачи:")
        self.speed_combo = QComboBox()
        self.speed_combo.addItems([
            "300", "1200", "2400", "4800", "9600", "19200", "38400",
            "57600", "115200", "230400", "250000", "500000", "1000000", "20000000"
        ])
        self.speed_combo.setCurrentText("9600")
        self.speed_combo.setEnabled(False)
        speed_layout.addWidget(self.label2)
        speed_layout.addWidget(self.speed_combo)

        button_layout = QHBoxLayout()
        self.scan_btn = QPushButton("Сканировать")
        self.scan_btn.clicked.connect(self.scan_ports)
        self.connect_btn = QPushButton("Выбрать")
        self.connect_btn.clicked.connect(self.connect_port)
        self.disconnect_btn = QPushButton("Отключиться")
        self.disconnect_btn.clicked.connect(self.disconnect_port)
        self.disconnect_btn.setEnabled(False)

        button_layout.addWidget(self.scan_btn)
        button_layout.addWidget(self.disconnect_btn)
        button_layout.addWidget(self.connect_btn)

        layout.addLayout(port_layout)
        layout.addLayout(speed_layout)
        layout.addLayout(button_layout)
        self.setLayout(layout)

    def scan_ports(self):
        self.port_combo.clear()
        ports = [port.device for port in serial.tools.list_ports.comports()]
        if ports:
            self.port_combo.addItems(ports)
            self.port_combo.setEnabled(True)
            self.speed_combo.setEnabled(True)
            self.connect_btn.setEnabled(True)
        else:
            QMessageBox.warning(self, "Ошибка", "Нет доступных COM-портов")

    def connect_port(self):
        port = self.port_combo.currentText()
        baudrate = int(self.speed_combo.currentText())

        try:
            self.serial_port = serial.Serial(
                port=port,
                baudrate=baudrate,
                timeout=1
            )
            self.parent.serial_port = self.serial_port
            self.parent.connected_status.setText(f"Подключено {port}")
            self.disconnect_btn.setEnabled(True)
            self.connect_btn.setEnabled(False)
        except Exception as e:
            QMessageBox.critical(self, "Ошибка", f"Не удалось подключиться: {str(e)}")

    def disconnect_port(self):
        if self.serial_port and self.serial_port.is_open:
            self.serial_port.close()
        self.parent.serial_port = None
        self.parent.connected_status.setText("Не подключено")
        self.disconnect_btn.setEnabled(False)
        self.connect_btn.setEnabled(True)
