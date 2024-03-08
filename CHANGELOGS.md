# EnKdevs Ocarina of Time/Majora's Mask Tracker Changelogs


1.0.5-dev
- Removed dev progress trackers
- Added songs to the upper layout
- Fixed GS Count Label covering Bullet Bag, preventing it from being upgradeable
- Added Disabled/Enabled Lists for Song Images

1.0.6-ootDev:
- Added rest of the missing item icons to the UI
- Fixed Lists in Constants.cs missing paths to certain item icons

1.0.6-ootDev+build.2:
- First version of Data Saving/Data Reading functionality

1.0.6-ootDev+build.3:
- UI is being set properly after reading data from `trackerState` file

1.0.6-ootDev+build.4:
- Implement remaining item activation/deactivation logic

1.0.0-beta.1+ocarina:
- Start of the private beta test

1.0.0-beta.2+ocarina:
- A whole lot of code refactoring
- Locations are more responsive now

1.0.0-beta.3+ocarina:
- Embedded used font into the application
- Operating Systems would fall back on the next available fonts because the app relied on you installing the used font.
- This is now fixed by having the font being bundled with the app

1.0.0-beta.4+ocarina:
- Fixed a crash that occured if you attempted to load a non-existing `trackerState` file
- Implemented logging that logs pretty much everything.

1.0.0
- Initial release (HOORAY!)

2.0.0-ootDev+build.1
- Initial start of V2.0.0 developments
- Redesigned UI interfaces
- Changed file saving and reading methods

2.0.0-ootDev+build.2
- More UI redesigns
- Changed some internal list orders
- Split internal lists up in order for UI redesigns to make sense
- Split `ChildTradingSequence` and `AdultTradingSequence` Lists up
- -> New lists are `ChildTradingItemsDisabled`, `ChildTradingItemsEnabled`, `AdultTradingItemsDisabled` and `AdultTradingItemsEnabled`
- More work on file saving and reading methods
- Added more disabled icon variants

2.0.0-ootDev+build.3
- Added constant values for disabled Maps, Compasses, Keys and Boss Keys
- Added constant values for enabled Maps, Compasses, Keys and Boss Keys
- Resized the Tracker
- A lot of data field additions
- Even more UI redesigns

2.0.0-ootDev+build.4
- Moved dungeon names a slight bit more upwards to make room for the dungeon types.
- UI population for maps, compasses, keys, key counts and boss keys
- UI adjustments for existing elements
- Even more data field additions
- Changed the data format on how tracker data is stored

2.0.0-ootDev+build.5
- More UI population for maps, compasses, keys, key counts and boss keys (Also includes dungeon types)
- Added constant `SolidColorBrush` definitions that are used for no keys, keys and all keys.

2.0.0-ootDev+build.6
- Added functionality to save everything related to dungeons (Maps, Compasses, Keys, Key Count, Dungeon Types, Boss Keys)
- Added functionality to toggle maps, compasses and dungeon types.
- Added functionality to switch dungeon types between `VANILLA` and `MQ`

---

1.0.0-mmDev+build.1:
- TBA
