I want to get a kitten -- [ref](/ideas/kitten.jpg)

[ VVVV  Actual Ideas Are Below  VVVV ]

# 2013-02-27
* The character sheet I'm using for testing is the Knight sheet I use in my day-to-day D&Ding. Knights don't get billions of feats, but certain classes do (*cough* fighter *cough*). As such it is easily possible to acquire more
feats than can fit on the character sheet. I know that the unadulterated Fighter sheet uses the Special Abilities list for extra Feat slots (providing at least 35 feat slots in total). If the application works well, it's a good idea
to support more than one type of character sheet (sheets with varying numbers of slots for feats and class features). The sheets themselves will need some way of identifying themselves as certain types. An easy way of doing this is
to query the string stored in the "Class and Level" node. It wouldn't work for multiclass characters, however. In the short-term, it would be good practice to avoid using constants wherever list sizes are concerned (instead
initialising them when a sheet is loaded).

# 2013-02-28
* Not really an idea, more like something I need to do later. Add check to make sure the user isn't trying to overwrite the current level XML file with the next level XML.

# 2013-03-10
* Maybe General should have the ability to create "battle logs"; text files which record what happens and what round it happens in.