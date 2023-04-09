import socket

if __name__ == '__main__':
    
    BLUETOOH_ADDRESS="58:91:cf:eb:8b:78"

    ## setup socket server
    server = socket.socket(socket.AF_BLUETOOTH, socket.SOCK_STREAM, socket.BTPROTO_RFCOMM)
    server.bind((BLUETOOH_ADDRESS, 4))
    server.listen(1)

    client, address = server.accept()