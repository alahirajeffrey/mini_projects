from flask import Flask

app = Flask(__name__)

## index page
@app.route('/')
def index():
    return 'Welcome'

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