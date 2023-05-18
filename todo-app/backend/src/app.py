from flask import Flask, jsonify
from flask_sqlalchemy import SQLAlchemy
from datetime import datetime

# create sqlalchemy extension
db = SQLAlchemy()
# create flask app
app = Flask(__name__)
# configure the SQLite database, relative to the app instance folder
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///todo_db.sqlite'
# initialize the app with the extension
db.init_app(app)

## define todo model
class Todo(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(100), nullablle=False)
    detail = db.Column(db.String)
    completed = db.Column(db.Boolean, default=False)
    date_created = db.Column(db.DateTime(), nullable=False, default=datetime.utcnow)

# create table from todo model
with app.app_context():
    db.create_all()

## index page
@app.route('/')
def index():
    return jsonify({'message': 'Welcome'})

## create todo
@app.route('/todo', methods=['POST'] )
def create_todo():
    return 'todo created'

## get all todos
@app.route('/todo', methods=['GET'])
def get_all_todos():
    return 'todos'

## get todo by id
@app.route('/todo/<id>', methods=['GET'])
def get_todo_by_id(id):
    return 'todo'

## delete todo by id
@app.route('/todo/<id>', methods=['DELETE'])
def delete_todo_by_id(id):
    return 'todo deleted'

## update todo by id
@app.route('/todo/<id>', methods=['PATCH'])
def update_todo(id):
    return 'todo updated'

if __name__ == "__main__":
    app.run(debug=True)