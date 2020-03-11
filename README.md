# Chromium-Password-Recovery
Recover locally saved accounts on Chrome and other Chromium based browsers. This project tested on Chrome v80 and new Edge Chromium. Also it working with old Chrome versions (v79 and below).

Chromium changed encryption mechanism on v80 and it using AES-256-GCM. This tool decrypt passwords with BCrypt functions. No need any DLL files.

# For More Info 
The new machanism of Chrome is as follows (from https://xenarmor.com/how-to-recover-saved-passwords-google-chrome/ ):
New Chrome version (v80.0 & higher) uses Master Key based encryption to store your web login passwords.

Here is how it generates the Master Key. First 32-byte random data is generated. Then it is encrypted using Windows DPAPI (“CryptProtectData”) function. To this encrypted key, it inserts signature “DPAPI” in the beginning for identification.

Finally this key is encoded using Base64 and stored in “Local State” file in above “User Data” folder.

Below is the sample entry of encrypted master key.

"os_crypt":{"encrypted_key":"RFBBUEkBAAAA0Iyd3wEA0RGbegD...opsxEv3TKNqz0gyhAcq+nAq0"},

Now to store the web login password, Chrome encrypts it using AES-256-GCM algorithm with the above master key and 12-byte random IV data. Finally, it inserts signature “v10” to the encrypted password and stores it in above “Login Data” file.
