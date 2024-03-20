VCS version control system used to control version of and text file and other files with info (undo in word is also a kind of version control)(any text editor the is monitoring the changes)
SCM sorce code management sytesm to control version of code files

GiT is a distributes Version Control system
git has repo on you local(where has SVN don't it has only copy of source code only one central repo)
git not need to commitcate with central server to submit commits annd change(need only to push the code)
-faster
-no network access required(to commit the code)
-no single failure point (In SVN if central repo is faild we have problem not in git)

git help <command> to find help
git do not require a network connection for local commits
we can fork a project
-work independently and submit changes set for inclusion or rejection


we can config git in three level

System level
(location:program_files/git/etc/gitconfig(windows), /etc/gitconfig(linux))
git config --system <options>

User level
(location:$HOME/.gitconfig(windows), ~/.gitconfig(linux))
git config --global <options>

Project level
my_project/.git/.config
git config <options>

we can config many options
like
git config --global user.name "dilip"
git config --global user.email "dilip@kumar.com"
google for more configs
git config --list(to view config)



git init  (initializes new git)
git remote add origin [repo url] (gives remote location to local git)

git has all it refs SHA in refs directory

git uses changes set along with metadata like username, time, authore, commit message(we can data with git log) and part of parent hash to generate new hash for change set uses a hashing algoritham. So it is not essay to modify a commit. when we amend a recent commit a new hash is genearated for old commit changes we rebase

git log (to view commit logs)

option
git log -n
git log --since=2020-01-01
git log --untill=2020-01-01
git log --after=2.weeks --before=3.days
git log --authour="dilip"
git log --grep="[any word]"
git log <commit_hash>..HEAD(begging_commit..ending_commit)
git log --oneline(for shorter(less description) for logs)
git log <folder_name>/<file_name>
git log <branch_name>
git log <tree-ish>
formating git log
git log -p (will show the log details and changes made for that commit)
git log --stat(shows the statics for changes which files are changed and how much changed)
git log --format=<option>(options are online,short,medium,full,fuller,email,raw)
git log --graph
git loh --graph --all --oneline --decorate


git manage structure can be found in .git(hidden folder) in the project


git is a three tree achitecture repository-->staging_index-->working_copy(checkout->stage(add) and commit)
other VCS have two tree achitecture we have repository-->working_copy(checkout and commit)


To see diff for staged and modified files
git diff
git diff --staged(diif of staged files) also git diff --cached
after git diff use "F" key for forward and "B" key for backword(uses pagination)
when the editor is open type "-S" to chop the lines when they are warpped and type the same to revert back
git diff --color-words(only see words are which are changed)
git diff <commit1_first>..<commit2_last>(last commit can be replaced with HEAD keyword)

To see changes for a commit 
git show <commit_hash>(6-8 charater of hash can used find commit also works all git diff commands) and work with --color-words flag


//note "--" refers to current branch
undo files 
git checkout -- <file name>[. for all files] or git restore <file_name>
git reset <file_name> or git reset HEAD <file_name> to undo from stage(unstage)
git reset <path>,..etc(removes files from index)(flag --soft(will not effect file),--hard(will discard all change in file brings to last commit(unrecoverable)))

git checkout <commit_hash> -- <file_name>(will revert file from that version)

git add -A(add all files); git add .(add all modified files)
git add <path>,<path2>... etc//(adds individual files in the specified path)

git rm -r directryname(if you want to delete the dir in git and you want it in local)
git rm <file.txt>
git mv orginalname newname(like linux rename)

git commit -a or git commit --all (skips the staging(adding) and commit the changes) wil not add untracked files and addes all modified files
git commit -am(with commit message)
git commit -m "give a brief discreption about changes"

git revert <commit_hash>

git clean -n//will tell what it will
git clean -f//will remove the files


//git ignore
to ignore file clear new file in project folder(where .git folder exits) and add file to ignore git will not track those files. if we add or edit .gitignore we need to commit it
we can regex, folder and files
examples *.log, temp/, temp/*.log, access.logs and negative expressions like if we do *.log we can add !access.log will excluded 
"#" is used  add comments
https://github.com/github/gitignore/ has common ignore files and exmaples

we can also ignore a file using following command on linux but we need git-extra packages on linux(not sure about windows)
git-ignore fileorfoldername/*(to ignore any file or folders)

git ignore tracked file. when a file is stage of tracked by git if add that file to gitignore. git will not ignore the file it will continue to track the file
to ignore trcaked file we need to remove it from git cached(cached and stage are not equal here)
git rm --cached <file_name>(it will keep the file and it will become untracked)


if we want a git ignore file global along all project we can create a global ignore file
it is USER SPECIFC. you should set it up in user/global file. Location and name of the file can be anything. it is preffer to keep in user forlder because it is user specific
following is the example 
git config --global core.excludesfile ~/.gitignore_global

git will not track empty folders to track add an empty can be anything but .gitkeep is prefreed
git ls-tree HEAD will show the tracking files 


Tree-ish
A tree in Git is a directory which contains files and other directories. If you drew a picture of the directory.
A directory containing files and other directories (which Git calls "trees") or any identifier which references a tree 
Git uses the term tree-ish to refer to both trees and to identifiers which reference a tree. when that commit has been applied. 
A commit is considered tree-ish because it refers to a tree at the point when a commit has been applied. 

Types of refrennces Tree-ish uses(we have more these are popular)
A tree-ish can be anything a directory, HEAD, branch, tag

SHA-1 hash
HEAD pointer reference
Branch refrence
Tag reference
Ancestry

Ancestry
to view the previous commit using a current commit we can use ^ or ~(Note: Following example use HEAD we can also use any commit has)
if we start from HEAD we can do HEAD^ it will to one commit back to go on we have to increase the number of "^" like HEAD^^, HEAD^^^ etc
instead we can use "~" to simplifiy HEAD~1 will go back to one commit HEAD~2,HEAD~3 etc 
git show HEAD^^^ or git show HEAD~3


git uses HEAD pointer to track the recent commit . HEAD is the tip to current branch, .git/HEAD file reference to where head is pointing to


ls-tree
git ls-tree is used to track when files are added to git using tree-ish(simple a commit). It will only give tree structure of current folder will not work repo level
git ls-tree HEAD/<commit_hash>
git ls-tree HEAD/<commit_hash> <folder_path>(will give details inside that folder)
//blob is file 
//tree is directory 


git branching
HEAD is diffent for diffrent branches. Git uses .git/HEAD file to track the head for branches(which inter point a folder it has all branch commit hashs)
git branch <branch_name>//to create a new branch
while creating a branch it will pick the current branch tip you cheaked in and create a new branch. may sure you are in right branch while creating a new one
git checkout <branch_name>// to change branch
git checkout -b <branch_name> create and checkout with one command
note: git cannot switch(checkout) if changes in working directory conflict(un tracked, new file and no conflicts changes will merge while checkout)
to merge use -m option git checkout -m <branch_name>
git diff <branch_name1>..<brach_name2> to comaper branches. we can aslo reverse name changes will show in revers order(to find what(features) that this branch is added to master)
git branch --merged to find which is merged into other branch it will give the branch in which code is involved
git branch -m <new_branch_name> //to rename the branch
git branch -d <branch_name> //to delete the branch
git branch -D <branch_name> //'-d' cannot delete if the commints in that branch are not merge to master or other branch
git branch -r shows the remote branches
gtt branch -a shows all branchs(both remote and local)

git barnch --set-upstream-to=origin/[branchname](to set for future use but first pull normally using above cmd)

git push(if you do not setup upstream(default branch) use below command)
git push origin branchname

git fetch

git pull origin <branchname>


git reset
All resets will move the HEAD Pointer. They will not remove the commit, commit is still there just moves the pointer. If have the copy(make sure to make a copy) of HEAD HASH/other commit hash, we can move to that point but unrefered commits are cleaned by git they will not stay longer. need to force push to remote

Soft reset
git reset --soft <tree-ish>
it will not change the staging index and working directory. used to merge commits or ammend commits.
Mixed Reset
git reset --mixed <tree-ish>
it will make chages to staging indes and will NOT make changes to working directory
Hard Reset
git reset --hard <tree-ish>
permenatly undo commit. removes from staging index and working directory


git merge
checkout to the branch you want to merge into and run the following command with the branch name you want to receive the changes from
git merge <tree-ish>
git diff --check //will give the line numbers where merge markers are

Fast-Forward VS Real-merge(non-FF merge)
FF merge : when merging a branch to master git will look at the histroy of master if nothing is merged(after making a branch from master(or any merge)) with use same commit(same commit) and will merge the code using same commit hash is call fast-forward merge.
Real merge: if any is merged from other branch to master. git wil create a new commit hash to merge the current branch

FF merge example : A->B->C a branch is created from master with commit "C". C->D new commits are added in newly created branch. when merging new branch to master the log looks like A->B->C->D;
Real merge example. If an other branch merge code to master like A->B->C->E. git finds a new merge the newly branch code is merge as A->B-C->E->F (F is merge of C)

spaces and tabs also cause merge conflicts

git stash save [name]
git stash show
git stash show -p
git stash list
git stash pop
git stash apply [stash[index]]
git stash clear
git stash drop <stash[index]>

git remote

git maintance a origin/mater pointer in local repo  to sync with remote repo<image>
git fetch will update the local pointer
git remote to get list of remotes
git remote -v for more info
git add remote origin <URL> points your remote URL to local origin
git remote rm origin to remove orgine
cat .git/config to find remotes config
git branch -r shows the remote branchs
gtt branch -a shows all branchs(both remote and local)

git clone

git clone <clone_url> [directory_name]

git remote and branhing
-u or --set-upstrem can be used to set tracking to remote branch(git help branching to know usage

git config has details about tracking branchs

origin/master is remote tarcking branch(origin is always points to remote)
master is local tracking branch

git push origin --delete <branch_name> (will delete the remote branch)


git push origin  <local_branch>:<remote_tracking_branch>
git push origin :<remote_tracking_branch>

