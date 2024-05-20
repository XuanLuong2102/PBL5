import sys
import cv2
import numpy as np
from PyQt6 import QtGui,QtWidgets
from PyQt6.QtCore import QThread,pyqtSignal,Qt
from PyQt6.QtMultimedia import QMediaPlayer, QMediaMetaData
from PyQt6.QtGui import QPixmap
from PyQt6.QtWidgets import *
from PyQt6.uic import loadUi
from gui import Ui_gui
from login import Ui_Login
import pyodbc

cnxn = pyodbc.connect('DRIVER={SQL Server};Server=XuanLuong\SQLEXPRESS;Database=data;UID=sa;PWD=123456')

# Cửa sổ login
class Login(QMainWindow):
    def __init__(self):
        super(Login,self).__init__()
        self.uic = Ui_Login()
        self.uic.setupUi(self)
        self.uic.BTlogin.clicked.connect(self.login)
    
    def login(self):
        username = "admin"
        password = "123"
        un = self.uic.user.text()
        pss = self.uic.password.text()
        
        if(username == un and password == pss):
            widget.setCurrentIndex(1)
        else:
            QMessageBox.warning(self,"Warring","Login fail")
# Cửa sổ Kiểm tra ngủ gật
# class Gui(QMainWindow):
#     def __init__(self):
#         super().__init__()
#         self.uic = Ui_gui()
#         self.uic.setupUi(self)
#         self.uic.label_3.setText("User: Admin")
#         self.uic.BtStart.clicked.connect(self.start_capture_video)
#         self.uic.BtStop.clicked.connect(self.stop_capture_video)
#         self.thread={}
    
#     def closeEvent(self, event):
#         self.stop_capture_video()
#     def stop_capture_video(self):
#         self.thread[1].stop()
#     def start_capture_video(self):
#         self.thread[1] = capture_video(index=1)
#         self.thread[1].signal.connect(self.show_webcam)
#         self.thread[1].start()
        
    
#     def  show_webcam(self, cv_img):
#         qt_img = self.convert_cv_qt(cv_img)
#         self.uic.lbCam.setPixmap(qt_img)

#     def convert_cv_qt(self,cv_img):
#         rgb_image = cv2.cvtColor(cv_img, cv2.COLOR_BGR2RGB)
#         h,w,ch=rgb_image.shape
#         bytes_per_line = ch*w
#         convert_to_Qt_fomat = QtGui.QImage(rgb_image.data,w,h,bytes_per_line,QtGui.QImage.Format.Format_RGB888)
#         p = convert_to_Qt_fomat.scaled(330,250,Qt.AspectRatioMode.KeepAspectRatio)
#         return QPixmap.fromImage(p)


# class capture_video(QThread):
#     signal = pyqtSignal(np.ndarray)
#     def __init__(self,index):            
#         self.index = index
#         super(capture_video,self).__init__()
        
#     def run(self):
#         cap = cv2.VideoCapture(0)
#         while True:
#             ret, cv_img =cap.read()
#             if ret:
#                 self.signal.emit(cv_img)
    
#     def stop(self):
#         self.terminate()
        

app = QApplication(sys.argv)
widget = QtWidgets.QStackedWidget()
login_f = Login()
#gui_f = Gui()

widget.addWidget(login_f)
#widget.addWidget(gui_f)
widget.setCurrentIndex(0)
widget.setFixedHeight(500)
widget.setFixedWidth(380)
widget.show()
app.exec()