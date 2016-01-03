package main
import b64 "encoding/base64"
import fmt

func main() {
	data := "YmFzZTY0IGVuY29kZWQgc3RyaW5n"
	sDec := b64.StdEncoding.DecodeString(data)
        fmt.Println(sDec)
}
