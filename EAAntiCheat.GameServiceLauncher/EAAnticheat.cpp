#include <Windows.h>
#include <iostream>
using namespace std;

int main() 
{
	STARTUPINFOA startup;
	PROCESS_INFORMATION pi;
	ZeroMemory(&startup, sizeof(startup));
	startup.cb = sizeof(startup);
	ZeroMemory(&pi, sizeof(pi));
	SetConsoleTitleA("EAAntiCheat.GameServiceLauncher(FAKE) by RikkoMatsumatoOfficial");
	if (!CreateProcessA("FC25.exe", (LPSTR)0, NULL, NULL, NULL, 0, NULL, NULL, &startup, &pi)) {
		MessageBoxA(0, "Not Founded FC25.exe", "EAAntiCheat.GameServiceLauncher", MB_OK | MB_ICONERROR);
		exit(443);
	}
	else {
		printf("Successfully Founded FC25.exe and Launching...");
		CloseHandle(pi.hProcess);
		CloseHandle(pi.hThread);
		exit(344);
	}
	return 0;
}
