use MIME::Base64;
$encoded = 'YmFzZTY0IGVuY29kZWQgc3RyaW5n';
$decoded = decode_base64($encoded);
print $decoded;
