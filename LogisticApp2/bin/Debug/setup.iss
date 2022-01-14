[Setup]
AppName=Arena Logistic App
AppVerName=Arena Logistic App Versi 1.0.0
AppPublisher=Arena Logistic Dev
AllowCancelDuringInstall = yes
DefaultDirName={pf}\Arena Logistic App
DefaultGroupName=Arena Logistic App
Compression = lzma
SolidCompression = yes
OutputBaseFilename=SetupArenaLogisticApp
AllowNoIcons = yes
AlwaysRestart = no
AlwaysShowComponentsList = no
DisableProgramGroupPage = yes
AppendDefaultDirName = yes
CreateUninstallRegKey = yes
DisableStartupPrompt = yes
LanguageDetectionMethod=none
ShowLanguageDialog=no
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\LogisticApp2.exe,0
UninstallDisplayName=Arena Logistic App
WindowVisible = no
AppCopyright=Copyright © 2021. Arena Logistic Dev
FlatComponentsList = yes
PrivilegesRequired = admin
VersionInfoVersion=1.0.0.0
SetupIconFile=Setup.ico
;WizardImageFile=SetupModern21.bmp
;WizardSmallImageFile=SetupModernSmall21.bmp

;[Languages]
;Name: ina; MessagesFile: compiler:Indonesia.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
Source: LogisticApp2.exe; DestDir: {app}; Flags: ignoreversion
Source: LogisticApp2.exe.config; DestDir: {app}; Flags: ignoreversion

Source: Database\DbLogistic2.mdb; DestDir: {app}\Database; Flags: ignoreversion

Source: LogoLogistic1.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\Arena Logistic App; Filename: {app}\LogisticApp2.exe; WorkingDir: {app}; IconFilename: {app}\LogoLogistic1.ico
Name: {userdesktop}\Arena Logistic App; Filename: {app}\LogisticApp2.exe; WorkingDir: {app}; IconFilename: {app}\LogoLogistic1.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Arena Logistic App"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue