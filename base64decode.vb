Dim base64Encoded As String = "YmFzZTY0IGVuY29kZWQgc3RyaW5n"
Dim base64Decoded as String
Dim data() As Byte
data = System.Convert.FromBase64String(base64Encoded)
base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data)
Console.WriteLine(base64Decoded)
