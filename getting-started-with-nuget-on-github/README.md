# Getting Started with NuGet on GitHub
The concept of a package manager in software development is not a new concept.
During the early days of .NET, developers struggled with sharing code and dependencies.
The language and framework was still very immature but gaining popularity fast.
As new version of the framework came out, we saw performance increases, new functionality, new abilities added to the languages, but no package management.
That is, until January 7th, 2011, when the first packages was published to NuGet.
Early adoption was slow, but soon it took off as the community realized the power and problems it solved (while, admittly, introducing a new set of problems).

Fast forward to today, developers and enterprise organizations not only can leverage community NuGet packages but they can also host their own internal NuGet packages.
Allowing teams to share their code with each other in a manner that has become second nature to .NET developers.

## Why use GitHub to host your NuGet packages?
As I stated just above, teams have a lot options and maybe too many options to host their own NuGet package.
Between open source and paid commercial solutions, how does one decide even how to get started?
To make matters worse, most developers know how to consume NuGet packages but most develoers have never created a NuGet package before.
They might contribute to one that has all of the automation built already, but they never started from scratch.
This is where GitHub comes into picture.

Teams or individual developers using GitHub get a feature called GitHub Packages from the start which allows teams and/or individual developers to store NuGet packages, among other type of packages.
At the time of this writing, the features for GitHub Packages between the various plans are identical, the difference is just the amout of storage you get.
This is important since there no additional setup or configuration you need to do when using GitHub Cloud.
If you are a GitHub Enterprise Server (GHES) user, you do need to add an external storage provider (which is a straight forward process) to enable GitHub Packages. Once you do that, all features of GitHub Packages becomes available.

Simply put, GitHub Packages allows you or your team to push your very frist NuGet package in minutes.
So if you are not leveraging NuGet in your projects now, you could be by the end of the day.

# Starting with Security
Security is obviously a hot topic and needs to be the starting point.
We are going to start sharing code and depending on the use case, we need to understand who will have access to the packages we make.

When using GitHub Packages as a NuGet registry, the packages are stored with the repository.
This is important because it determines who can see and consume this package in the first place.
Published NuGet packages use repository-scoped permissions in GitHub.
This means that in order for someone to consume a NuGet package, they need to have at a minimum read access to the repository.
It is also worth noting that public repositories allow anyone to access the packages.

## Authenticating to GitHub Packages
Now that we understand who can access the packages, we need to be able to authenticate against GitHub Packages to be able to consume them.
A lot of open source and paid commercial solutions allow for LDAP, NTLM, and/or OAuth authentication where as GitHub Packages only supports a Personal Access Token (PAT).
I will admit, this experience is not the best, but given the simplicity of getting up and running with GitHub Packages, tradeoffs are bound to happen.
Don't let this discourage you as the experience isn't bad (as you will see shortly), it just may not be the exact solution you are looking.

The first step is to generate a personal access tokn.
You can do this by logging into your GitHub account and going to "Settings -> Developer Settings -> Personal Access Tokens" ([Creating a personal access token][creating-a-personal-access-token]).
Next, we need to decide what scope to grant this token.
While it may be easy to simply grant all scopes, I'm a firm believer in scoping tokens to have the exact permissions needed to get the job done.
The below table will help us to figure out the permissions needed.

| Scope             | Description                                           | Required Repo Permission |
| ----------------- | ----------------------------------------------------- | ------------------------ |
| `read:packages`   | Download packages from the registry                   | read                     |
| `write:packages`  | Upload and publish packages to the registry           | write                    |
| `delete:packages` | Delete packages from the registry                     | admin                    |
| `repo`            | All of the above, plus full control over repositories | read, write, or admin    |

The *Scope* defines what the PAT is *allowed* to do.
So if you have the PAT with the `read:packages` scope, the most it can do is read packages in the registry.
You won't be able to use it to delete a packge or publish a package as it will give you a permissions error.
In order for the `read:packages` scope to read a package in the first place, you need to have (at a minimum) read permissions of the reopository that has the package.

If you create a PAT with just the `write:packages` scope selected, you need to have (at a minimum) write permissions to the repository.
However, if you try to use this PAT to read a package, it will fail.
The PAT is not scoped to read __and__ write packages, just write.
How you want to use this PAT will dictate what scopes you will need to select.
Later on, I'll discussion some best practices on managing PATs with regards to GitHub Packages.

Once you have selected the appropriate scopes, click "Generate token".
This will take you back to the list of PATs you have and you will see a box with the new token.
You will see a copy button next to it, make sure you click it highlight the token and copy it.
This will be your only oppourtunity to get the token.
Once you leave this screen, the plain text token will be gone and you will either need to regenerate it or delete it and start again.

![Generated Tokens](./images/personal_access_tokens.png)

One last thing to note when using PATs.
If your GitHub Organization(s) are integrated with SAML single sign-on, you will need to one extra step.
Notice the "Enable SSO" button in the screenshot above.
This is to allow you to use the token with organizations that have SSO enabled.
For more information, please read [Authorizing a personal access token for use with SAML single sign-on][authorizing-pat-single-sign-on].

<!-- Links -->
[creating-a-personal-access-token]: https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token
[authorizing-pat-single-sign-on]: https://docs.github.com/en/enterprise-cloud@latest/authentication/authenticating-with-saml-single-sign-on/authorizing-a-personal-access-token-for-use-with-saml-single-sign-on