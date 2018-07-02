This repository is for a dummy project to play around with Pull Requests.

Try creating pull requests with policies that fix the broken tests, and see what happens.


# Getting Started

To start you will need to fork this project onto the repository.

Clone the repository from ASOS VSTS

`git clone https://asos.visualstudio.com/DefaultCollection/EmergentTalent2017/_git/asos-interns-pull-request`

Add a remote to your own MSDN account VSTS
`git remote add myfork <uri>`

You need to get the Uri from the "Clone" option in your VSTS Account

Pull the branch you're interested in
`git pull origin <branch>`

Push the branch to your fork
`git push myfork <branch>`

Whenever you commit you should only push up to the "myfork" remote

Now you should clone the fork repository on your local machine and start going through the sessions.

# Creating a Pull Request
1. Create a new branch using `git checkout -b <branch_name>`
2. Make a small change (i.e. add a file) to your local git repository
3. Commit that change to your branch using `git commit`
4. Push your changes to the remote upstream using `git push`. Note: Git may prompt you to set your upstream.
5. Go to your VSTS repository
6. Go to Code > Branches. You should be able to see your branch listed here.
7. Go to Code > Pull Requests and "Create a New Pull Request"
8. You should be able to see and view your listed Pull Request

# Branch Policies
1. Go to Code > Branches
2. Click on the options for your branches, and select Branch Policies.
3. Play around with the various configurations available here, to understand what you can configure for a branches pull requests.

# Linking your branch with Continuous Integration
1. Go to the Branch Policies.
2. View Build Validation > Add build policy
3. From here, you are able to select various configurations that will run various build scenarios, and approve your pull request if they succeed.
4. As configuring a build definition for your repository is out of scope for this session (but coming up in a future one!!), talk to Matt or Dom to help set this up for you.
5. Have a play around with creating Pull Requests for broken tests and see what happens! You could change the Service.cs file to break the test, or force a compilation error.
