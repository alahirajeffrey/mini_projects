
from flask import Flask

app = Flask(__name__)

## index page
@app.route('/')
def index():
    return 'Welcome'

