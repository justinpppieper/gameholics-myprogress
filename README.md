# A tower defense game hehe

## Week 4 & Week 5
#### Enemy
1. reduce HP when shooted by *damage bullet*
2. slow down when shooted by *slowdown bullet*
3. healthBar
4. there are two types of enemies right now, we could customize the enemy's HP, Speed, and Value

#### Tower & Bullet
1. customize shooting range. If an enemy enters this range circle，the tower starts to shoot automatically. If the enemy leaves this range circle，the tower stops shooting.
2. automatically catch the nearest enemy and shoot it
3. there are two types of Tower & Bullet, one is *damage* tower and the other is *damage plus slowdown* tower

#### Player System
1. each enemy has a value property，when enemy is killed，player money += enemy value
2. when enemy arrives destination，player lives--
3. player lives and money are displayed on top canvas

#### GameManager
##### WayPoints
customize route(no change since week4)

##### WaveSpawner
1. customize number of waves
2. customize enemy type, number of enemies, and speed of enemies each wave

#### System
Rewrite *Enemy, Tower, Bullet* to inheritance structure, easy to add more types.



## Week 6: Integrations & Menus

### System Integration

#### Folder Structure

- Animations
  - UI: for all the animations related to UI (e.g. Button.controller)
  - Enemy
  - etc.
- Font (hardly changing)
- Prefabs
  - UI: for all prefabs related to UI (e.g. LevelButton.prefab)
  - Enemy
  - Tower
  - etc.
- Scenes (hardly changing)
- Scripts
  - Game Manager: for all scripts related to game mechanism management (e.g. GameStatus.cs)
  - UI: for all scripts related to UI Canvas, etc.
  - Enemy
  - Tower
  - etc.
- Sprites
  - Others: for game public components (e.g. HealthBar.png)
  - Enemy
  - Tower
  - Tiles: only for tilemap sprites
  - etc.
- Tilemap (only for tailmap palette)

### Github Integration

- Assets
- Pakages
- ProjectSettings
- .gitignore
- README.md

### Menus

- Connect scene by SceneFader component

- Menus (all functions work)

  1. Pause Menu(Press Space to trigger)
     - Back Button
     - Restart Button
     - Main Menu Button

  2. Win Level Menu
     - display rounds survived
     - Next Level Button
     - Main Menu Button

  3. Win Game Menu
     - display rounds survived
     - Main Menu Button

  4. Level Selector Menu
     - Level selector buttons: pass current level to unlock the next level
     - Reset Button: reset game progress; only level 1 is unlocked

## Week 7: Well I guess I would not have any progress this week......lue