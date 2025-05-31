# 🔨 SmashRangeMod

Supercharge your wall smashing experience in **House Flipper 2**!  
This mod enhances the *hammer smash range*, *fragment destruction area*, and *smash reach*, making demolitions faster, bigger, and more satisfying.

---

## 📦 Features

- 💥 **Bigger Smash Radius** — Enlarges the area affected when hitting a wall
- 🔧 **Customizable Settings** — Configure via MelonPreferences
- 🚧 **Adjustable Fragment Cleanup** — Control how much debris is auto-cleared
- 🧠 **Well-structured Code** — Separated patches, preferences, and main loader logic

---

## ⚙️ Requirements

- 🧩 [MelonLoader](https://melonwiki.xyz/) (v0.5.7 or newer)
- ✅ Game: **House Flipper 2 (IL2CPP version)**

---

## 🛠️ Installation

1. Download and install **MelonLoader** for House Flipper 2
2. Place the compiled `SuperSmash.dll` into the `Mods/` folder inside the game directory
3. Launch the game — configuration will be available at runtime

---

## 🗂️ Preferences

All parameters can be adjusted in `MelonPreferences.cfg` or via runtime tools like `MelonPreferencesManager`.

| Setting                   | Default | Description                            |
|--------------------------|---------|----------------------------------------|
| `smash_multiplier`       | `2`     | Multiplies the effective smash size    |
| `fragment_expand_range`  | `2`     | Extends bounds for wall fragment cleanup |
| `bounds_expand_size`     | `1`     | Expands smash bounding box in each axis |

---

## 🧪 Example

If `smash_multiplier = 3`, a standard hammer hit will affect **3× the original reach** — perfect for mass demolition!

---

## ⚠️ Performance Warning

🚨 **WARNING: Performance impact possible!**

Smashing large areas can create **many particles and fragments**.  
This may cause **FPS drops or stuttering**, especially on lower-end machines.  
Use higher values **at your own risk**.  

```diff
- It's powerful, but it's also heavy! 💻🔥
```
