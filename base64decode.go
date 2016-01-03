package main
import b64 "encoding/base64"

func main() {
	data := "YmFzZTY0IGVuY29kZWQgc3RyaW5n"
	sDec := b64.StdEncoding.DecodeString(data)
}
