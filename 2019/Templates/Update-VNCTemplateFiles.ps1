 cd 'B:\Visual Studio\2019\templates\ItemTemplates\VNC\VNC_IT_MVVM_Presentation_RESTAPI'

 
 $templateFolders = @(
    'B:\Visual Studio\2019\Templates\ProjectTemplates\VNC'
    , 'B:\Visual Studio\2019\Templates\ITEMTemplates\VNC'
 )
 ((Get-Content -path GetTYPEsEvent.cs) -replace 'customTYPE', 'xxxTYPExxx')

 Get-ChildItem -Path . -Filter *.cs

$files = (Get-ChildItem -Path . -Recurse -Filter *.cs)

$files = (Get-ChildItem -Path . -Recurse -Include *.cs, *xaml)

foreach ($file in $files)
{
    "BEFORE"
    ""
    Get-Content -path $file
    
    "AFTER"
    ""
    (Get-Content -path $file) | Foreach-Object {
    $_ -replace 'customAPPLICATION', 'xxxAPPLICATIONxxx' `
       -replace 'customTYPE', 'xxxTYPExxx' } | Set-Content $file

    Get-Content -path $file

    Read-Host -Prompt "Press Enter to Continue"
}

$files = (Get-ChildItem -Path . -Recurse -Include *.cs, *xaml)
$files
