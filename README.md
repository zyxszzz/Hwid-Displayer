# Hwid-Displayer
Uma ferramenta simples que obtém o HWID (Hardware ID)

Ela é bem simples e obtém o HWID apenas com essa linha de código: System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
Retornando uma string que seria o HWID

Vc pode usar pra checar seu HWID ou até mesmo, se vc usa spoofer, descobrir se ele ta ou não funcionando

É bem simples então é útil pra quem ta começando agora com C#

string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

print(HWID);

Com isso retorna o HWID.

brunin#0007

![unknown](https://user-images.githubusercontent.com/72706297/129390163-f496c5d2-2483-46cf-aaf7-f5c31f8c6bf5.png)
