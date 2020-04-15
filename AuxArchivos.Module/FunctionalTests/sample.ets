;#DropDB AuxArchivosEasyTest

#Application AuxArchivos.Win
#Application AuxArchivos.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef AuxArchivos.Win

*Action About...
 
*Action OK

#EndIf

#IfDef AuxArchivos.Web
*Action Navigation(My Details)
#EndIf
