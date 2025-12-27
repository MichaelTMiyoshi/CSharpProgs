# VSCodeConsoleApps

A couple things about VS Code and GitHub.

VS Code assumes that you are a professional coder.  Which means that it assumes you know how to use Git from the command line.  So here are a few things to do in the VS Code terminal and on GitHub.com that will make you feel like a pro.  (At least a little bit.)

## A better way (that I did second, but listing first)

1. Create a project in Visual Studio Code.
2. Go to [gitignore.io](https://gitignore.io) to create a .gitignore file.  You will put in "Csharp" and "VisualStudioCode" (without the double quotes) into the box next to the green CREATE button.
3. Create a text file (you can do this in VS Code or another app that creates text files.)
4. Name the file .gitignore
5. Go to your folders and make sure that the .gitignore file is in the same directory as your top level project solution file (.sln).
6. Use the version control on VS Code to create your repository.
7. Publish the repository to GitHub.
8. Remember to pull your code before you work on things.  Then, edit.  Then, commit and push when you are done.  Do this every time you edit your code.

## A second way (that I used first)

On GitHub:

1. Create a repostitory on GitHub.com.  You will obviously need to login to do this.
   - As a student, you should make the repository private.
   - I like to use the MIT license.
   - Create a .gitignore (even though we are going to overwrite it soon).
   - You may choose to create a readme file.  You can do this now, or at a later time.
3. Go to [gitignore.io](https://gitignore.io) to create a .gitignore file.  You will put in "Csharp" and "VisualStudioCode" (without the double quotes) into the box next to the green CREATE button.
4. Press the green CREATE button.
5. Highlight all the text on the page and copy it.
6. Back on GitHub, edit the .gitignore file.  (Click on its name, then click on the pencil icon on the right side of the page).
7. Highlight all the text in the .gitignore file and delete it.
8. Paste the text from the .gitignore file you created on gitignore.io.
9. Save the file by pressing the green Commit changes... button.

After you have done the above, you can go back to Visual Studio Code.

[Note on step 4 below:  You can keep your personal email private in your GitHub settings.  Go the the gear of your account (below your picture or the circle with green and white rectangles) to find your settings and then click the email settings.  You will see that you can then make your email private so that the world cannot just see it.  It will also give you an email that you can use in step 4 below so that people can contact you about your repository, but not have direct access to your email.  This is the email that you should use in step 4 below.  It will look something like a bunch of numbers plus your username followed by @users.noreply.github.com.]

In Visual Studio Code:

1. Make sure that Git is installed on your computer.  You will get a message when you press the Source Control button if it is not installed.  Install it for the correct operating system you are using.
2. Now you get to operate like a pro.  Click on the terminal tab in VS Code.  (If it is not showing on the bottom of your IDE, go to the view menu and click on terminal to make it show.
3. On the right side of the terminal area you should see a plus sign (+) next to an upside down carat (a carat looks like this ^).  Press that upside down carat and find the word BASH and click it.  On a Windows PC, it probably says Git Bash.  Make sure that the little window next to the right of the terminal is highlighting bash.
4. Type the following commands in the terminal.
   - git config --global user.email "your email address here"  (Make sure to use the email address you used to set up github.)
   - git config --global user.name "your github name here"  (Make sure to use the username (the one that shows up after github.com/) you use for github.
   - git config --global init.defaultBranch main  (This makes sure that the main branch is called main.)
5. Make sure that you are in the folder where your repository lives on the computer.  You can check the folder by typing ls in the terminal.  This will let you see what files and folders are in the folder where you are.  If you are not in the proper folder, type cd foldername (still in the terminal).  Do this until you are in the proper folder.
6. You will need to go to github to copy the name of the repo.  To do that, click on the repository name.  Once at the repo, you will see the green button that says <> Code.  You will get a few options when you press the green Code button.  The option you want is the button that copies the URL of your repository.  It looks like a couple pieces of paper slightly offset from each other.  Press that to copy the URL.
7. Type the following commands back in the terminal of VS Code:
   - git init
   - [Note: You should notice something new once you do this.  The word "main" will show up in parentheses next to your folder name.  foldername (main)  This indicates that you now have a local repository.]
   - git pull URL main
   - [Note: paste the URL into the command.  It will look like git pull https://github.com/yourname/yourrepo main]

Now, you should be able to commit and push your changes to GitHub.  Make sure to give a commit message when you commit.  I like to put in the date and say what I did.  It would be great if you did the same thing or something similar.  Professionals use the commit message as a way to track what they do.  You should do the same.
