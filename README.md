# M5

## les 1 opdracht 1
![ballen](https://github.com/user-attachments/assets/3ccc12ae-b220-4805-91e4-190613894830)

[![ballen](<Assets/scripts/les 1/create ball.cs>)](https://github.com/AT-STjemoeder/progJaar2/blob/main/Assets/scripts/M5/les%201/create%20ball.cs)

ik heb hier een random ballen spawner gemaakt met random kleuren en locatie en functions argument en return types geleerd
## les 1 opdracht 2
![tower](https://github.com/user-attachments/assets/4f62b866-666f-4fed-88d2-dc6f6adb596f)

https://github.com/AT-STjemoeder/progJaar2/blob/main/Assets/scripts/les%201/tower.cs

ik heb geleerd hoe ik met randomizer met een m1 click een toren kan laten spawnen op een verschillende plek en verschillende grotes



## les 2
![actionevent](https://github.com/user-attachments/assets/db680336-92c7-434d-a456-584b142345c2)

https://github.com/AT-STjemoeder/progJaar2/tree/main/Assets/scripts/M5/les%202

ik heb hier met action events een blokje gemaakt dat als het tegen een balletje aan gaat de score omhoog gaat

## les 3
<img width="1919" height="586" alt="image" src="https://github.com/user-attachments/assets/0c4c8f08-23ba-4738-96ed-2de141a9a46a" />

hier maak ik gebruik van een breakpoint om te debuggen


## les 4
![space](https://github.com/user-attachments/assets/f49c13eb-c059-47c2-8893-4af1db155495)

hier heb ik een bestaande "game" single response gemaakt en niet DRY
https://github.com/AT-STjemoeder/Space48

# M6

## les 2
```mermaid

classDiagram

class Enemy{
    +int maxHealth
    -int currentHealth
    +TakeDamage()
    -Die()
}

class PlayerCombat{
+Animator animator
+Transform attackPoint
+LayerMask enemyLayers
+int attackDamage
+float attackRange
-Attack()
-OnDrawGizmosSelected()
}
class PlayerLegdeGrab{
    +float rayStartOffset
    +float ray1Height
    +float ray2Height
    +float rayLength
    +LayerMask climbableLayer
    +Vector 3 grabOffset
    +float grabSpeed
    -PlayerCore core
    -bool controlsEnabled
    -Checkforledge()
    -IEnumrator LedgeClimbRoutine()
    -float GetDirectionInput()
    -OnDrawGizmos()
}
class PlayerJump{
    +float jumpForce
    -float extraJumpTime
    -float _jumpTimeCounter
    -Playermove move
    -PlayerCore core
}
class PlayerMove{
    +float moveSpeed
    +float lastInput
    -PlayerCore core
    -SpriteRenderer spriteRenderer
    -void HandleAnimations()
}
class PlayerCore{
    +LayerMask groundLayer
    +float groundRayOffset
    +float groundRayLength
    +bool IsGrounded()
}
class CameraFollow{
    -Transform target
    -float smoothSpeed
    -Vector3 offset
    -LateUpdate()
}
class EnemyFollow{
    -float moveSpeed
    -Transform
    Startfollow()
}

class EnemyDetect{
    -string playertag
    -Enemyfollow followScript
    -OnTriggerEnter()
}
PlayerMove <|-- PlayerJump
PlayerCore <-- PlayerJump
PlayerCore <--PlayerMove
PlayerCore <--PlayerLegdeGrab
EnemyFollow <-- EnemyDetect
PlayerCombat <-- Enemy
```
hier heb ik mermaid leren te gebruiken zodat het makkelijker te begrijpen is voor de mensen die het niet hebben gecodeerd en het willen begrijpen.
## les 3

![scriptebleObject](https://github.com/user-attachments/assets/5b23ea17-f6b9-42ae-85b1-b9ccd22fb311)

Hier hebben we geleerd om verschillende structs te gebruiken in unity zoals enums en scriptable objects en ook het verschil tussen een struct en een class.

## les 4

![delegates](https://github.com/user-attachments/assets/cbd27462-7bf9-4408-80b3-db7b9ee88f4f)

hier heb ik gebruik gemaakt van delegate's zodat ik de score kon aanpassen in realtime op het canvas.


## les 7
``` Csharp
public bool IsPlayerReadyToAttack(Player player)
{
 if (player == null) return false;
 if (!player.IsAlive) return false;
 if (player.AttackCooldown >0) return false;

 if (player.Target == null) return false;
 if (!player.Target.IsAlive) return false;

float distance = Vector3.Distance(player.transform.position, player.Target.transform.position)
if (distance >= 5f) return false;

if (player.IsStunned) return falsel
if (player.IsSlowed) return false;

bool hasManaAndWeapon
if (player.Mana >= 20 && player.WeaponEquipped)
        hasManaAndWeapon = true;

bool hasHealthAndBuff
if(player.Health > 30 && player.HasBuff("Strength"))
    hasHealthAndBuff = true;

if(!hasManaAndWeapon && !hasHealthAndBuff) return false;

    return True;
}
```

