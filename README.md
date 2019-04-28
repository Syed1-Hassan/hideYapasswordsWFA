# hideYapasswords 
# Windows Form Application.


**Paswords Manager**


**hideYApasswords** first asks user to save 3 digit passcode. **(which would be asked again n again when user wants to access his/her hidden passwords)**

Saves Email and Password's key in the text file.

User can access his hidden passwords via Entering Email OR Pasting Password's key(saved in the Txt file). 

![hideYApasswordsWFA](https://github.com/Syed1-Hassan/hideYApasswordsWFA/blob/master/hideYApasswords%20Screen%20shots/ss1.PNG)

![hideYApasswordsWFA](https://github.com/Syed1-Hassan/hideYApasswordsWFA/blob/master/hideYApasswords%20Screen%20shots/ss2.PNG)

![hideYApasswordsWFA](https://github.com/Syed1-Hassan/hideYApasswordsWFA/blob/master/hideYApasswords%20Screen%20shots/ss3.PNG)


* **Used datastructure Dictionary<TKey, TValue>** to save every alphabetical and numeric character's key. 

* **Used LINQ** to search in dictionary for decrypting or encrypting. 

* **Used REGEX** to fetch Encrypted Password from the txt file.
