string base64Encoded = "YmFzZTY0IGVuY29kZWQgc3RyaW5n";
string base64Decoded;
byte[] data = System.Convert.FromBase64String(base64Encoded);
base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data);
Console.WriteLine(base64Decoded)
