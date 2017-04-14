dotnet restore

dotnet publish -c Release -o out

SET PublishFile="publish.zip"
IF EXIST %PublishFile% del /F %PublishFile%
powershell.exe -nologo -noprofile -command "& { Add-Type -A 'System.IO.Compression.FileSystem'; [IO.Compression.ZipFile]::CreateFromDirectory('out', '%PublishFile%'); }"


