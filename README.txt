Author: Rudri Pota  
Student number: 0817379  
Purpose: Document and review the architecture of a robust MVC web application to generate a product catalogue for a fictional company named Savvy Sock Sack, allowing for CRUD operations.  

Started README.txt at 2023-10-10 

0707(intentional chose a lucky time!) 

steps that preeceded it: 
Choose asp.net mvc model from the list  
Go to your user id, the choose source->repos  
Click on �Place solution and project in same directory�  
Click on next and choose net 3.1  
Click on ctrl+n and make a README.txt file  
Press ctrl+F5 to run without debugging, downloaded the SSL certificate (note: the program will not run on browser without removing the ssl port from properties->launchsettings.json. Remember to remove the comma!) 

0738 
created a logo for the company
problem: tried to modify the index but css did not work 
solution: added in-file css by using <style>

0756
it worked, looks adorable!
made a repo and added the code there
went home

2023-10-11 0707
cleaned the solution
rebuilt it
created an about us page
added css
uploaded it all to github

0723
created a new controller, named it hello socks for humor reasons

0727
created a new view 
error: forgot to make a separate folder for it!
corrected it now

07436
linked it to the main header

0801
added properties to my newly built model
coffee break

0805
line was too long, came baack

0820
Added nuget package chose the second option in sub category called manage nget package for solution 
Searched for Microsoft.EntityFrameworkCore.SqlServer and installed it
what I installed

Installing:

Microsoft.Bcl.AsyncInterfaces.1.1.1
Microsoft.Bcl.HashCode.1.1.1
Microsoft.CSharp.4.5.0
Microsoft.Data.SqlClient.1.1.3
Microsoft.EntityFrameworkCore.3.1.11
Microsoft.EntityFrameworkCore.Abstractions.3.1.11
Microsoft.EntityFrameworkCore.Analyzers.3.1.11
Microsoft.EntityFrameworkCore.Relational.3.1.11
Microsoft.EntityFrameworkCore.SqlServer.3.1.11
Microsoft.Extensions.Caching.Abstractions.3.1.11
Microsoft.Extensions.Caching.Memory.3.1.11
Microsoft.Extensions.Configuration.3.1.11
Microsoft.Extensions.Configuration.Abstractions.3.1.11
Microsoft.Extensions.Configuration.Binder.3.1.11
Microsoft.Extensions.DependencyInjection.3.1.11
Microsoft.Extensions.DependencyInjection.Abstractions.3.1.11
Microsoft.Extensions.Logging.3.1.11
Microsoft.Extensions.Logging.Abstractions.3.1.11
Microsoft.Extensions.Options.3.1.11
Microsoft.Extensions.Primitives.3.1.11
Microsoft.Identity.Client.3.0.8
Microsoft.IdentityModel.JsonWebTokens.5.5.0
Microsoft.IdentityModel.Logging.5.5.0
Microsoft.IdentityModel.Protocols.5.5.0
Microsoft.IdentityModel.Protocols.OpenIdConnect.5.5.0
Microsoft.IdentityModel.Tokens.5.5.0
Microsoft.NETCore.Platforms.2.0.0
Microsoft.NETCore.Targets.1.1.0
Microsoft.Win32.Registry.4.5.0
Newtonsoft.Json.10.0.1
runtime.native.System.4.3.0
runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-arm64.runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-x64.runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-x86.runtime.native.System.Data.SqlClient.sni.4.4.0
System.Collections.4.3.0
System.Collections.Concurrent.4.3.0
System.Collections.Immutable.1.7.1
System.Collections.NonGeneric.4.3.0
System.Collections.Specialized.4.3.0
System.ComponentModel.4.3.0
System.ComponentModel.Annotations.4.7.0
System.ComponentModel.Primitives.4.3.0
System.ComponentModel.TypeConverter.4.3.0
System.Configuration.ConfigurationManager.4.5.0
System.Diagnostics.Debug.4.3.0
System.Diagnostics.DiagnosticSource.4.7.1
System.Diagnostics.Tools.4.3.0
System.Diagnostics.Tracing.4.3.0
System.Dynamic.Runtime.4.3.0
System.Globalization.4.3.0
System.Globalization.Extensions.4.3.0
System.IdentityModel.Tokens.Jwt.5.5.0
System.IO.4.3.0
System.IO.FileSystem.4.3.0
System.IO.FileSystem.Primitives.4.3.0
System.Linq.4.3.0
System.Linq.Expressions.4.3.0
System.Net.NameResolution.4.3.0
System.Net.Primitives.4.3.0
System.ObjectModel.4.3.0
System.Private.DataContractSerialization.4.3.0
System.Reflection.4.3.0
System.Reflection.Emit.4.3.0
System.Reflection.Emit.ILGeneration.4.3.0
System.Reflection.Emit.Lightweight.4.3.0
System.Reflection.Extensions.4.3.0
System.Reflection.Primitives.4.3.0
System.Reflection.TypeExtensions.4.3.0
System.Resources.ResourceManager.4.3.0
System.Runtime.4.3.0
System.Runtime.Caching.4.5.0
System.Runtime.CompilerServices.Unsafe.4.5.0
System.Runtime.Extensions.4.3.0
System.Runtime.Handles.4.3.0
System.Runtime.InteropServices.4.3.0
System.Runtime.Numerics.4.3.0
System.Runtime.Serialization.Formatters.4.3.0
System.Runtime.Serialization.Json.4.3.0
System.Runtime.Serialization.Primitives.4.3.0
System.Security.AccessControl.4.5.0
System.Security.Cryptography.Cng.4.5.0
System.Security.Cryptography.Primitives.4.3.0
System.Security.Cryptography.ProtectedData.4.5.0
System.Security.Permissions.4.5.0
System.Security.Principal.Windows.4.5.0
System.Security.SecureString.4.3.0
System.Text.Encoding.4.3.0
System.Text.Encoding.CodePages.4.5.0
System.Text.Encoding.Extensions.4.3.0
System.Text.RegularExpressions.4.3.0
System.Threading.4.3.0
System.Threading.Tasks.4.3.0
System.Threading.Tasks.Extensions.4.3.0
System.Xml.ReaderWriter.4.3.0
System.Xml.XDocument.4.3.0
System.Xml.XmlDocument.4.3.0
System.Xml.XmlSerializer.4.3.0

Note to self: download nuget package in every computer!!!

0847
cried for a bit
completed the next steps, everything got a little messy
browser runs
no compile time errors
pushing this code before starting migration so if something goes wrong I will hop onto the next computer

SavvySockSack

Uninstalling:

Microsoft.IdentityModel.JsonWebTokens.5.5.0
Microsoft.IdentityModel.Logging.5.5.0
Microsoft.IdentityModel.Protocols.5.5.0
Microsoft.IdentityModel.Protocols.OpenIdConnect.5.5.0
Microsoft.IdentityModel.Tokens.5.5.0
Newtonsoft.Json.10.0.1
System.Dynamic.Runtime.4.3.0
System.IdentityModel.Tokens.Jwt.5.5.0
System.Linq.Expressions.4.3.0
System.ObjectModel.4.3.0
System.Runtime.Numerics.4.3.0
System.Security.Cryptography.Cng.4.5.0

Updates:

Microsoft.Bcl.AsyncInterfaces.1.1.1 -> Microsoft.Bcl.AsyncInterfaces.1.1.0
Microsoft.Bcl.HashCode.1.1.1 -> Microsoft.Bcl.HashCode.1.1.0
Microsoft.Data.SqlClient.1.1.3 -> Microsoft.Data.SqlClient.1.0.19269.1
Microsoft.EntityFrameworkCore.3.1.11 -> Microsoft.EntityFrameworkCore.3.1.1
Microsoft.EntityFrameworkCore.Abstractions.3.1.11 -> Microsoft.EntityFrameworkCore.Abstractions.3.1.1
Microsoft.EntityFrameworkCore.Analyzers.3.1.11 -> Microsoft.EntityFrameworkCore.Analyzers.3.1.1
Microsoft.EntityFrameworkCore.Relational.3.1.11 -> Microsoft.EntityFrameworkCore.Relational.3.1.1
Microsoft.EntityFrameworkCore.SqlServer.3.1.11 -> Microsoft.EntityFrameworkCore.SqlServer.3.1.1
Microsoft.Extensions.Caching.Abstractions.3.1.11 -> Microsoft.Extensions.Caching.Abstractions.3.1.1
Microsoft.Extensions.Caching.Memory.3.1.11 -> Microsoft.Extensions.Caching.Memory.3.1.1
Microsoft.Extensions.Configuration.3.1.11 -> Microsoft.Extensions.Configuration.3.1.1
Microsoft.Extensions.Configuration.Abstractions.3.1.11 -> Microsoft.Extensions.Configuration.Abstractions.3.1.1
Microsoft.Extensions.Configuration.Binder.3.1.11 -> Microsoft.Extensions.Configuration.Binder.3.1.1
Microsoft.Extensions.DependencyInjection.3.1.11 -> Microsoft.Extensions.DependencyInjection.3.1.1
Microsoft.Extensions.DependencyInjection.Abstractions.3.1.11 -> Microsoft.Extensions.DependencyInjection.Abstractions.3.1.1
Microsoft.Extensions.Logging.3.1.11 -> Microsoft.Extensions.Logging.3.1.1
Microsoft.Extensions.Logging.Abstractions.3.1.11 -> Microsoft.Extensions.Logging.Abstractions.3.1.1
Microsoft.Extensions.Options.3.1.11 -> Microsoft.Extensions.Options.3.1.1
Microsoft.Extensions.Primitives.3.1.11 -> Microsoft.Extensions.Primitives.3.1.1
System.Collections.Immutable.1.7.1 -> System.Collections.Immutable.1.7.0
System.Diagnostics.DiagnosticSource.4.7.1 -> System.Diagnostics.DiagnosticSource.4.7.0

2023-10-12
1056
IT WORKED!!!
error: stupid mistake, I wrote savvy sock sack context instead of mvc socks context in appsettings.json file
solution: corrected it
socks was made in view to control crud

1135
too many errors
many confusions, but finally sorted it out
changed namespaces a lot of times
addedsock folder as a controller in _layout
database created by using:
Add-Migration InitialCreate (to create)
Update-Database (to update)

1154
tried and ran

1217
added search facility
button yet to add
everything runs

0258
cloned the repo on a different computer
cleaned the sln
rebuilt the solution
reinstalled nuget packages
hoping the database still works
IT STILL WORKS WOOHOOOO!

0331
successfuly added a search field form, might add search by size later depending on the time and energy

0436
added a field
was confused about what dattype to add for ratings
searched google and double worked out
source: https://www.w3schools.com/sql/sql_datatypes.asp
remebered to delete the data from everywhere
ERRORRRR
Soultion: was very smart and forgot to initialise migration for rating and to update the database
works now
edit did not work, realized I never added a field for rating in edit from crud pages

0451
now trying to use css for the data base page!
works
now changing privacy page
Privacy policy template used from https://www.privacypolicytemplate.net/ 

0521
project is almost completed!
just a few finishing touches are needed
going home and completeing those

0902
tried to update database at home to run the program but it showed an error and the program did not run
it showed brower error
stressed so quit

2023-10-13 1000
cleaned and rebuilt the project
found out that these are the words that amke me the happiest:
Update-Database
Build started...
Build succeeded.
Done.
trying to add validation

1037
what it says if the user messes up name field:
The Name field is required.

what it says if the user messes up material field:
The field Material must be a string with a minimum length of 3 and a maximum length of 60.

what it says if the user messes up pattern field:
The field Pattern must be a string with a minimum length of 5 and a maximum length of 50.

what it says if the user messes up price field:
The field Price must be a number.

what it says if the user messes up rating field:
The field Rating must match the regular expression '^(0(\.[0-9]+)?|5(\.0+)?)$'.

1047
published the website
successful project, its been an honour

extra notes from the author:
this was the third time I rebuilt the project savvy socks
First time:
Major error saying
Tried to create readme.md on github
Git push failed, unable to push to remote repo because your local branch is behind the remote branch. Update your branch by pulling before pushing. 
Then saying pull failed. 
Panicked 
tried to figure it out but rebuilding the project seemed like the easiest solution
database would not run on the second time