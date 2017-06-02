echo off
ipconfig /flushdns
pause
netsh winsock reset
pause
netsh int ip reset
echo "Restart?"
pause
shutdown /r /t 0
exit