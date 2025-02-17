import sys
from PyQt6.QtWidgets import QApplication
from laser_compute_lab import LaserComputeLab


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = LaserComputeLab()
    window.show()
    sys.exit(app.exec())