# Avalon Mud Client

## Quick Tips

### How to Update

1. `Help->Update Client` will check for a new release.  If a new release exists it will download the installer from GitHub and start the installer for you.  It will know the correct 32-bit/64-bit one based off of what you previously installed.  **NOTE**: Once the installer has finished downloading it will close the client.  If you are currently in a game be aware of this.

### Input Box

1. The backslash key `\` will select the entire input box if you press it.
2. The `up` and `down` arrow keys will cycle through the history of your commands.
3. Typing `#` will pull up a list of hash commands to choose from, continuing to type will filter the list.
4. Typing `#go` will pull up built in directions that are stored in the Directions tab.
5. Pressing `Page Up` or `Page Down` will show you the back buffer panel.  `Escape` will hide it (or if you page all the way to the bottom)
6. Pressing `Escape` will clear the input box of any text in it.

### General Tips

1. `Control-Tab` will switch between the main tabs at the top.
2. The client will save your settings when you exit the client.  It does not auto-save currently.  If you want to exit the client without saving you can use `File->Exit Without Save`.
3. In the `Settings->Client Settings` you can change the `SaveDirectory` setting to change where profiles save.  I've found it handy to have my profile save into a cloud storage folder (e.g. Dropbox, Box, OneDrive) folder which is then available on all of my computers.  This has the added benefit of acting as a backup so you can restore old versions of your profile.
4. If you download any shared triggers and aliases and make changes to them you can use the `Lock` feature to lock them.  You will still be able to manually update them but auto-updates will skip these.  This means you can alter the stock triggers and make sure your changes are the ones that stay (but also be able to update the rest of them).
5. To add a new record in the `Aliases`, `Triggers` or `Directions` tab scroll to the bottom of the grid and begin adding in the last row.  Note: In the future we will also have custom entry forms that will be more robust.
6. If you have a large amount of text to to the game, like a note, you can use the `Tools->Send Text to Game`.  This will send your text line by line with a small pause in between each line to prevent disconnections in the case where some muds disconnect you for spamming too many commands at once (which is common Diku muds).