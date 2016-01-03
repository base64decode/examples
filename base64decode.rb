require "base64"

encoded_string = 'YmFzZTY0IGVuY29kZWQgc3RyaW5n'
decoded_string = Base64.decode64(encoded_string)
puts decoded_string
