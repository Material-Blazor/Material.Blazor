Get-ChildItem -Recurse *.scss | foreach {
$FileName = $_.FullName;
[System.Io.File]::ReadAllText($FileName) | Out-File -FilePath $FileName -Encoding UTF8;
}