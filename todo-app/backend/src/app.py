from flask import Flask, jsonify, request
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
    title = db.Column(db.String, nullable=False)
    detail = db.Column(db.String)
    completed = db.Column(db.Boolean, default=False)
    date_created = db.Column(db.DateTime(), nullable=False, default=datetime.utcnow)

    def serialize(self):
        return {
            "id": self.id,
            "title" : self.title,
            "detail": self.detail,
            "completed": self.completed,
            "date_created": self.date_created
        }

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
    title = request.form.get('title')
    detail = request.form.get('detail')
    new_todo = Todo(title=title, detail=detail)
    db.session.add(new_todo)
    db.session.commit()
    return jsonify({"message":"todo created"}) 

## get all todos
@app.route('/todo', methods=['GET'])
def get_all_todos():
    todos = Todo.query.all()
    return [todo.serialize() for todo in todos]

## get todo by id
@app.route('/todo/<int:id>', methods=['GET'])
def get_todo_by_id(id):
    todo = db.get_or_404(Todo, id)
    return todo.serialize()
    

## delete todo by id
@app.route('/todo/<int:id>', methods=['DELETE'])
def delete_todo_by_id(id):
    todo = db.get_or_404(Todo, id)
    db.session.delete(todo)
    db.session.commit()
    return jsonify({"message":"todo deleted"})

## update todo by id
@app.route('/todo/<int:id>', methods=['PATCH'])
def update_todo(id):
    todo = db.get_or_404(Todo, id)
    todo.completed = True
    db.session.commit()
    return jsonify({"message":'todo updated'})
