import socket

if __name__ == '__main__':

    ## connect to bluetooth server
    client = socket.socket(socket.AF_BLUETOOTH, socket.SOCK_STREAM, socket.BTPROTO_RFCOMM)

    bluetooth_address = input("Input MAC address of bluetooth server: ")
    client.connect((bluetooth_address, 4))

    ## setup bluetooth messaging
    try:
        while True:
            message = input('Enter message: ')
            client.send(message.encode('utf-8'))
            data = client.recv(1024)
            
            if not data:
                break
            print(f"Message: {data.decode('utf-8')}")

    except OSError as err:
        print(err)

    ## close client connection
    client.close()