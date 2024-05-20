from flask import Flask, jsonify
import pyodbc

app = Flask(__name__)

def connectSQL():
    server = 'XuanLuong\SQLEXPRESS'
    database = 'PBL5'
    username = 'sa'
    password = '123456'
    conn_str = f'DRIVER={{SQL Server}};SERVER={server};DATABASE={database};UID={username};PWD={password}'

    try:
        conn = pyodbc.connect(conn_str)
        return conn.cursor()
    except pyodbc.Error as e:
        print(f"Error connecting to SQL Server: {e}")
        return None

def fetch_data_from_table(table_name):
    cursor = connectSQL()
    if cursor:
        try:
            cursor.execute(f'SELECT * FROM {table_name}')
            rows = cursor.fetchall()
            columns = [column[0] for column in cursor.description]
            data = [dict(zip(columns, row)) for row in rows]
            return data
        except pyodbc.Error as e:
            return {"error": f"Error executing SQL query: {e}"}
        finally:
            cursor.close()
    else:
        return {"error": "Failed to connect to the database"}

@app.route('/tables')
def get_tables():
    return jsonify({"tables": ["Users", "History","Action"]})

@app.route('/<table_name>')
def get_data_from_table(table_name):
    data = fetch_data_from_table(table_name)
    return jsonify(data)

if __name__ == '__main__': 
    app.run(host='0.0.0.0')


