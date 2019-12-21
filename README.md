# hideYapasswords 
# Windows Form Application.


**Paswords Manager**


**hideYApasswords** first asks user to save 3 digit passcode.
This 3 digit passcode would be asked every time the user wants to get his/her password.

Saves Email and Password's key in the text file.

User can access his hidden passwords via Pasting Password's key(saved in the Txt file). 
Moreover recently added password can be accessed just by entering Email.
**Incase user forgets his 3 digit passcode there's no backup so user have to delete the text file saved in Documents "encryptedCode.txt"**


![hideYApasswordsWFA](https://github.com/Syed1-Hassan/hideYApasswordsWFA/blob/master/hideYApasswords%20Screen%20shots/ss1.PNG)

![hideYApasswordsWFA](https://github.com/Syed1-Hassan/hideYApasswordsWFA/blob/master/hideYApasswords%20Screen%20shots/ss2.PNG)

![hideYApasswordsWFA](https://github.com/Syed1-Hassan/hideYApasswordsWFA/blob/master/hideYApasswords%20Screen%20shots/ss3.PNG)

* **Used datastructure Dictionary<TKey, TValue>** to save every alphabetical and numeric character's key. 

* **Used LINQ** to search in dictionary for decrypting or encrypting. 

* **Used REGEX** to fetch Encrypted Password from the txt file.
