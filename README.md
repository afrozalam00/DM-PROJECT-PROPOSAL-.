# DM-PROJECT-PROPOSAL-.
RSA ALGORITHM
Group Members
Wajahat Ali Khalid
Faizan Sidd
Afroz Alam
Rahim Ahmed Khan

INTRODUCTION
 Introduction
RSA encryption and decryption algorithm talks about secrecy of messages between two users. It involves a public key and a private key generation. The public key can be known to everyoneand is used for encrypting messages. Messages encrypted with the public key can only bedecrypted using the private key. The private key is not publicly known, it is only known toreceiver so that she / he can decrypt the encrypted message. These keys !public and private keys"for the RSA algorithm are generated using some mathematical operations. The principal goal of design of any encryption algorithm must be security against unauthori#edattacks. $ithin the last decade, there has been a vast increase in the accumulation andcommunication of digital computer data in both the private and public sectors. Much of thisinformation has a significant value, either directly or indirectly, which requires protection. RSAis an Asymmetric key cryptography which provides security against unauthori#ed attacks.&roblem 'efinition $hat is RSA Algorithm and mathematics behind it ( RSA Algorithm) Someidea of RSA algorithm has been given in abstract above. *ou may refer that again for moreinformation. The encryption and decryption in the RSA algorithm as follows) +irst, I had togenerate the key pair and then those keys were to be used for encryption and decryption. Key generation RSA involves a public key and a private key. The mathematics behind RSA algorithmis as follows

Project Description
In this class file, RSA algorithm related functions are available like calculating phi, n, square, and modulus. RSA algorithm is step in this project to encrypt and decrypt text. This algorithm encrypts and decrypts the plane text, i.e., each text gets encrypted and decrypted.
The Main Concepts In this project, takes as input, in console user section, , After taking input, HEX function extracts the text HEX code, HEX code is converted into cipher text depending on RSA settings. An opposite, Cipher text gets loaded, then apply RSA algorithm, then decipher the text, resultant string is converted .

DESCRIPTION OF HMAC:
The cryptographic strength of the HMAC depends upon the cryptographic strength of the underlying hash function, the size of its hash output, and the size and quality of the key.

HMAC uses two passes of hash computation. The secret key is first used to derive two keys – inner and outer. The first pass of the algorithm produces an internal hash derived from the message and the inner key. The second pass produces the final HMAC code derived from the inner hash result and the outer key. Thus the algorithm provides better immunity against length extension attacks.

An iterative hash function breaks up a message into blocks of a fixed size and iterates over them with a compression function. For example, SHA-256 operates on 512-bit blocks. The size of the output of HMAC is the same as that of the underlying hash function (e.g., 256 and 1600 bits in the case of SHA-256 and SHA-3, respectively), although it can be truncated if desired.

HMAC does not encrypt the message. Instead, the message (encrypted or not) must be sent alongside the HMAC hash. Parties with the secret key will hash the message again themselves, and if it is authentic, the received and computed hashes will match.  

DESCRIPTION OF MD5 :
MD5 message digest algorithm is the 5th version of the Message Digest Algorithm developed by Ron Rivest to produce 128 bit message digest. MD5 is quite fast than other versions of message digest which takes the plain text of 512 bit blocks which is further divided into 16 blocks, each of 32 bit and produces the 128 bit message digest which is a set of four blocks, each of 32 bits. MD5 produces the message digest through five steps i.e.  padding, append length, divide input into 512 bit blocks, initialize chaining variables a process blocks and 4 rounds, uses different constant it in each iteration.

MD5 Algorithm was developed with the main motive of security as it takes an input of any size and produces an output if a 128-bit hash value. To be considered cryptographically secure MD5 should meet two requirements:

   1. It is impossible to generate two inputs that cannot produce the same hash function.
   2. It is impossible to generate a message having the same hash value.

Initially, MD5 was developed to store one way hash of a password and some file servers also provide pre-computed MD5 checksum of a file so that the user can compare the checksum of the downloaded file to it. Most Unix based Operating Systems include MD5 checksum utilities in their distribution packages.

DESCRIPTION OF HMAC-SHA1:
In cryptography, SHA-1 (Secure Hash Algorithm 1) is a cryptographic hash function which takes an input and produces a 160-bit (20-byte) hash value known as a message digest – typically rendered as a hexadecimal number, 40 digits long. It was designed by the United States National Security Agency, and is a U.S. Federal Information Processing Standard.

Since 2005 SHA-1 has not been considered secure against well-funded opponents,as of 2010 many organizations have recommended its replacement. NIST formally deprecated use of SHA-1 in 2011 and disallowed its use for digital signatures in 2013. As of 2020, attacks against SHA-1 are as practical as against MD5;as such, it is recommended to remove SHA-1 from products as soon as possible and use instead SHA-256 or SHA-3. Replacing SHA-1 is urgent where it is used for signatures.

All major web browser vendors ceased acceptance of SHA-1 SSL certificates in 2017.In February 2017, CWI Amsterdam and Google announced they had performed a collision attack against SHA-1, publishing two dissimilar PDF files which produced the same SHA-1 hash.

DESCRIPTION OF HMAC-MD5:
So any cryptographic hash function, such as SHA-256 or SHA-3, may be used in the calculation of an HMAC; the resulting MAC algorithm is termed HMAC-X, where X is the hash function used (e.g. HMAC-SHA256 or HMAC-SHA3). The cryptographic strength of the HMAC depends upon the cryptographic strength of the underlying hash function, the size of its hash output, and the size and quality of the key.

The HMAC uses two passes of hash computation. The secret key is first used to derive two keys – inner and outer. The first pass of the algorithm produces an internal hash derived from the message and the inner key. The second pass produces the final HMAC code derived from the inner hash result and the outer key. Thus the algorithm provides better immunity against length extension attacks.

Thus an iterative hash function breaks up a message into blocks of a fixed size and iterates over them with a compression function. For example, SHA-256 operates on 512-bit blocks. The size of the output of HMAC is the same as that of the underlying hash function (e.g., 256 and 1600 bits in the case of SHA-256 and SHA-3, respectively), although it can be truncated if desired.

HMAC does not encrypt the message. Instead, the message (encrypted or not) must be sent alongside the HMAC hash. Parties with the secret key will hash the message again themselves, and if it is authentic, the received and computed hashes will match. 
