param(
    [Parameter(Mandatory=$True,
            ValueFromPipeline=$True)]
    $filePath
)

$hasher = [System.Security.Cryptography.SHA256]::Create()
$content = Get-Content -Path $filePath -AsByteStream -Raw
$hash = [System.Convert]::ToBase64String($hasher.ComputeHash($content))
Write-Output ($filePath.ToString() + ": " + $hash)