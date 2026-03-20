# VoiceMeeter Potato Cooldown Bypass

This tool modifies the live memory of Voicemeeter Potato to automatically bypass the donationware popup and timer because nobody deserves to wait 300+ seconds to hear their audio :P If you enjoy Voicemeeter or make money from it consider paying for it at [their official website](https://vb-audio.com/Voicemeeter/potato.htm)

If you found this helpful consider leaving a ⭐

### How I Did It
I used Cheat Engine and found the exact memory pointer (`voicemeeter8.exe+0x13B518`) that controls the nag screen timer This C# script uses the `swed64` library to continuously write a `1` to that address in the background locking the timer and preventing the popup from ever showing

### Usage
1. Open Voicemeeter Potato.
2. Run the bypass `.exe` as an Administrator (required to let the tool edit memory)
3. Leave the tool running in the background

### Important Notes & Disclaimer
* **Support the Devs:** This script is for personal use. If you use Voicemeeter for work please buy a license
* **Antivirus Warnings:** Because this edits the memory of another program Windows Defender will likely flag it as a HackTool or Trojan This is a false positive normal for memory bypasses
* **Disclaimer:** Provided as is I am not responsible for any issues Downloading `.exe` files off the internet is always a risk so please feel free to read the C# source code and compile it yourself
