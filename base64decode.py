import base64
encoded = 'YmFzZTY0IGVuY29kZWQgc3RyaW5n'
data = base64.b64decode(encoded)
print data
