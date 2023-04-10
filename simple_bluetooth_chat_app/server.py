import socket

# mac address of bluetooth server
BLUETOOH_ADDRESS = "58:91:cf:eb:8b:78"

if __name__ == '__main__':

    # setup socket server
    server = socket.socket(socket.AF_BLUETOOTH,
                           socket.SOCK_STREAM, socket.BTPROTO_RFCOMM)
    server.bind((BLUETOOH_ADDRESS, 4))
    server.listen(1)

    # accept request from client
    client, address = server.accept()
    print(f"Connection from {address} has been established")

    # setup bluetooth messaging
    try:
        while True:
            data = client.recv(1024)
            if not data:
                break
            print(f"Message: {data.decode('utf-8')}")
            message = input('Enter message:')
            client.send(message.encode('utf-8'))

    except OSError as err:
        print(err)

    # close client and server connection
    client.close()
    server.close()
