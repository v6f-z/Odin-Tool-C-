; Sharp Odin Protocol By Anas — Inno Setup installer script
; Build via: "C:\Program Files (x86)\Inno Setup 6\ISCC.exe" installer\setup.iss

#define MyAppName "Sharp Odin Protocol By Anas"
#define MyAppVerName "Sharp Odin Protocol By Anas"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "AMProTeam"
#define MyAppExeName "Sharp_Odin_Protocol_By_Anas.exe"
#define MyAppIco "..\Sharp Odin Protocol By Anas\Samsung_Advanced_Flasher.ico"
#define MyRelDir "..\Sharp Odin Protocol By Anas\bin\Release"

[Setup]
AppId={{935212F5-019F-4FE2-89D0-1CC5DD1553E1}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppVerName}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf32}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
PrivilegesRequired=admin
OutputDir=..\dist
OutputBaseFilename=Setup-Sharp-Odin-Protocol-1.0.0
SetupIconFile={#MyAppIco}
UninstallDisplayIcon={app}\{#MyAppExeName}
UninstallDisplayName={#MyAppName}
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
ArchitecturesInstallIn64BitMode=
ArchitecturesAllowed=x86compatible

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "arabic"; MessagesFile: "compiler:Languages\Arabic.isl"

[Files]
Source: "{#MyRelDir}\*.exe";                DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyRelDir}\*.exe.config";         DestDir: "{app}"; Flags: ignoreversion
Source: "{#MyRelDir}\*.dll";                DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent