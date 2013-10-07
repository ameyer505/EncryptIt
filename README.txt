***ENCRYPTIT README FILE***
Developed and Written by Alex Meyer
Last Date Updated: 10-7-2013

Questions or comments can be directed to alex.itguy@gmailcom

This program encrypts and decrypts files using AES symmetric key cryptography. It uses
a 256 bit key to encrypt its contents. All data is encrypted multiple times, the minimum
being 5 times the maximum being 15 (this was chosen for speed and size of file limitations).
The number of passes made can be set by the user, by going to File -> Encryption Settings.

As a note the number of passes used to encrypt a file MUST BE the same as the number of passes
chosen to decrypt the file.

During encrypting the applications writes the encrypted file back to the directory that the 
unencrypted is currently in, using this format:

<filename>-encrypted.txt

During decryption the application writes the decrypted file back to the directory that the encrypted file
is currently in, using the format:

<filename>-decrypted.txt

Use this program at YOUR OWN RISK, there are no safeguards for if you forget the password to a file and I
can not help you ascertain lost keys.

***A Cryptic Applications Production***
