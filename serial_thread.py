from PyQt6.QtCore import QThread, pyqtSignal
import serial


class SerialThread(QThread):
    data_received = pyqtSignal(str)

    def __init__(self, parent):
        super().__init__(parent)
        self.parent = parent

    def run(self):
        while True:
            if self.parent.serial_port and self.parent.serial_port.is_open:
                try:
                    data = self.parent.serial_port.readline().decode('ascii', errors='ignore')
                    if data:
                        self.data_received.emit(data.strip())
                except Exception as e:
                    print(f"Serial error: {str(e)}")
                    break
            self.msleep(100)