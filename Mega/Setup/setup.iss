; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Mega Browser"
#define MyAppVersion "1.0.0.0"
#define MyAppPublisher "Pixel Cowboy Studios"
#define MyAppURL "https://github.com/DJZK"
#define MyAppExeName "Mega.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9B621548-8741-40FB-985E-08DD8B23D6F6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={userappdata}\Pixel Cowboy Studios\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
LicenseFile=D:\PC\Desktop\Builder\Mega\docs\EULA.txt
InfoBeforeFile=D:\PC\Desktop\Builder\Mega\docs\System Requirements.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=D:\PC\Desktop\Builder\Output
OutputBaseFilename=mega-setup
SetupIconFile=D:\PC\Desktop\Builder\Mega\docs\mega.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\PC\Desktop\Builder\Mega\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\PC\Desktop\Builder\Mega\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\PC\Desktop\Builder\Runtimes\dotNet.exe"; DestDir: "{app}\runtimes"; Flags: ignoreversion; AfterInstall: RunDotNet
Source: "D:\PC\Desktop\Builder\Runtimes\webview.exe"; DestDir: "{app}\runtimes"; Flags: ignoreversion; AfterInstall: RunWebView

[Code]
procedure RunDotNet;
var
  ResultCode: Integer;
begin
  if not Exec(ExpandConstant('{app}\runtimes\dotNet.exe'), '', '', SW_SHOWNORMAL,
    ewWaitUntilTerminated, ResultCode)
  then
    MsgBox('Other installer failed to run!' + #13#10 +
      SysErrorMessage(ResultCode), mbError, MB_OK);
  if ResultCode > 0 then
    WizardForm.Close;
  
end;
procedure RunWebView;
var
  ResultCode: Integer;
begin
  if not Exec(ExpandConstant('{app}\runtimes\webview.exe'), '', '', SW_SHOWNORMAL,
    ewWaitUntilTerminated, ResultCode)
  then
    MsgBox('Other installer failed to run!' + #13#10 +
      SysErrorMessage(ResultCode), mbError, MB_OK);
  
  if ResultCode > 0 then
    WizardForm.Close;
 
end;


[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

