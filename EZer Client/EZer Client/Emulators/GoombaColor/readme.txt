Goomba Color 03-31-2008
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
By Dwedit (Dan Weiss)
http://www.dwedit.org/gba/goombacolor.php

It's a Game Boy Color emulator for the Game Boy Advance.
- Why? Because the GB Micro and DS can't play GBC games!

Stay tuned for updates!  Check the Pocketheaven forums for a later version!
http://www.pocketheaven.com/boards/viewforum.php?f=29

Known Issues:
	Savestates are broken, therefore DISABLED in this version.
	Timing may be off
	No "hi-color mode"

Todo:
	Fix Savestates
	Add real HDMA
	Fix the broken games
	Add mid-screen palette changes


Getting Started
-=-=-=-=-=-=-=-
Before you can use Goomba Color, you need to add some GB roms to the emulator.
This emulator package includes a tool to do this called "Goomba Front".
Make sure you do NOT overwrite the emulator file by using "goomba.gba" as your
output file.

You can also append games onto the emulator using the "DOS" command prompt:
copy /b goomba.gba+game1.gb+game2.gb goomba_out.gba

Or with a unix prompt (for Mac/Linux users):
cat goomba.gba *.gbc *.gb *.sgb > goomba_out.gba

Make sure the games' sizes are correct, otherwise your rom compilation will stop
at the first file with an incorrect size.  Also make sure the files have a
proper Nintendo header.

You can also insert a splashscreen file immediately after the emulator, and
before the first included game.

Also make sure your flashing software allocates 64kByte/512kbit SRAM for Goomba
Color.  If your flash cartridge software does not allow you to allocate 64KB,
use goomba_save32.gba instead of goomba.gba.


Note: I did not make Goomba Front.  It is buggy and does may have problems with
certain path names, especially pathnames containing international characters.


Controls
-=-=-=-=

Menu navigation:  Press L+R to open the menu, A to choose, B (or L+R again) to
cancel.

Speed modes:  L+START switches between throttled/unthrottled/slomo mode.

Quick load:  R+START loads the last savestate of the current rom.

Quick save:  R+SELECT saves to the last savestate of the current rom (or makes
a new one if none exist).

Sleep:  START+SELECT wakes up from sleep mode (activated from menu or 5/10/30
minutes of inactivity)


Other Stuff
-=-=-=-=-=-=-

Gameboy SRAM: Goomba Color automaticly takes care of games which use 8KB SRAM.
IMPORTANT!
If you are using a game with a 32KB sized SRAM save, you must manually save the
SRAM by entering the menu with L+R.

Link transfer:  Sends Goomba Color to another GBA.  The other GBA must be in
  multiboot receive mode (no cartridge inserted, powered on and waiting with
  the "GAME BOY" logo displayed).  Only one game can be sent at a time, and
  only if it's small enough to send (128kB or less). A game can only
  be sent to 1 (one) Gameboy at a time, disconnect all other gameboys during
  transfer.
Use an original Nintendo cable!
Multi player link play: NOT DONE YET.

Go Multiboot: Allows you to play without a cartridge!  For small games only,
  128k or less.  This feature makes "Link transfer" kinda useless.
  Note: You can't eject a cartridge from a Gamecube Game Boy Player while it is
  running.

Pogoshell Plugin: If you wish to use Goomba Color with Pogoshell,
  copy goomba.gba to your plugins directory,
  then edit pogoshell's configuration file.
  DO NOT rename "goomba.gba" to "goomba.mb", or try to compress it.
  Goomba Color is a ROM program, not a multiboot program.

GameBoy Player:
  To be able to check for the GameBoy Player one must display the
  GameBoy Player logo, the easiest way to get it is by downloading it from
  Flubba's  homepage. Otherwise you can rip it from any other game that displays
  it (SMA4 & Pokemon Pinball). This is a must if you want rumble to work.


Speed Hacks
-=-=-=-=-=-
Goomba Color now has some speed hacks available to try to speed up games.
Leave speedhacks off if the game's speed does not improve.

Double Speed:  Controls whether the emulated GBC runs in double speed mode or
               not.  There are two modes for this option:

  Full       - Emulates the GBC at full double speed.  While games are getting 
               all the CPU time they need, the emulator may not be able to 
               keep up, so games may run half as fast.
               This is the default mode.
  Half Speed - GBC's processor stays at half-speed.
               Some games will reach realtime speed, other games may be
               starved for the CPU and run half as fast.
               This setting may cause some games to crash.

LCD Hack:  Many games have idle loops which repeatedly poll the LCD Status registers or scanline number.  The LCD hack options make the emulator skip ahead 
in time when a game reads from the scanline number or LCD status register, so 
games run faster in the emulator.
Some games may crash with this turned on.  Many games will fail to do wavy 
backgrounds correctly with this setting turned on.

  OFF     - The default setting.  Disables all LCD hacks.
  Low     - Turns on the scanline number hack, and eats some cycles on LCD 
            status polling.
  Medium  - Eats more cycles on LCD status polling.
  High    - Eats a lot of cycles on LCD status polling, crashes some games.


Files Included
-=-=-=-=-=-=-=-
Gbctrim.exe -         This is a bank-by-bank ROM trimmer for Game Boy or
                      Game Boy Color games.  Trimmed roms are only compatible
                      with Goomba Color, not other emulators.
                      Some games do not work properly after being trimmed,
                      such as Dragon Warrior Monsters 2.
Goombafront.exe -     Tool to build Goomba Color compilations.  It works by
                      appending roms to the end of goomba.gba
goomba.gba -          Main emulator file
goomba_save32.gba -   Alternative version for cartridges limited to 32K saves
goomba_mb.gba  -      Multiboot version of Goomba Color
readme.txt -          This awful file
history.txt -         Version History


ROM Version
-=-=-=-=-=-

Goomba Color now runs from ROM, and the standard "goomba.gba" file can no longer
be booted over a multiboot cable.  If you want to boot Goomba Color over a
multiboot cable, or otherwise want to run the emulator in multiboot mode, and
you do not have a flash cartridge, you can use "goomba_mb.gba", which is the
mutiboot version of the program.
Note that "goomba.gba" also contains a complete copy of "goomba_mb.gba" embedded
inside to allow the "Go Multiboot" and "Link Transfer" features to work.
(that's also why the emulator is two times bigger than previous versions)


More Information
-=-=-=-=-=-=-=-=-

For more information, go to the Pocketheaven.com message boards
http://www.pocketheaven.com/boards/viewforum.php?f=29

! Thank you:
-=-=-=-=-=-=-
Red Mage - page hosting, testing
newbie and the nation of Japan - Goomba Front, testing
MarkUK - testing
Markus Oberhumer - LZO compression library
Jeff Frohwein - MBV2
Neal Tew - For PocketNES
Forgotten - For VisualBoy(Advance)
Chishm - For the cool FAT driver


-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
Fredrik Olsson
flubba@passagen.se
http://hem.passagen.se/flubba/gba.html
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
Dan Weiss
danweiss@gmail.com
http://www.dwedit.org/

