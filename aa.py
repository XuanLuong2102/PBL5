
import pyodbc 
print(pyodbc.drivers())
cnxn = pyodbc.connect('DRIVER={SQL Server};Server=XuanLuong\SQLEXPRESS;Database=data;UID=sa;PWD=123456')
