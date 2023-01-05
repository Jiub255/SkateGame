public class AAAAAA
{/*-----------------------------------------------------------------------------------------------------------------------------

                                            _____  __    __     __
                                              |   /  \  |  \   /  \  *
                                              |  {    } |   } {    } *
                                              |   \__/  |__/   \__/
                                            _________________________






    ----------------------------------------------------------------------------------------------------------------------------

    2D Sideview Skateboarding Metal/Punk Platformer/Endless Runner

        This is going to be more involved than I thought.
            Use rigidbody2d/physics?
                Thinking no again. Just control the player position based on the position and slope of the ground
                    Higher slope = higher speed obviously.
                    Don't have realistic physics where you speed up downhill, just different slopes = different speeds
                    Pushing gives you a boost? Or just increases speed, which gradually decreases on flat ground?
                    Could use rigidbody for gravity for jumping maybe? Maybe even rolling? Not sure yet.
                        Use a plain ball as the physics base and have the actual player/board sprites follow with script? Seems not too bad so far.
                            The board and player's position/rotation can change based off angle of ground, whether in air or not, speed, whatever else.
                At most for the board/player movement/jump/roll downhill, have the tricks and stuff be non-physics based though.
            Have a crouch and ollie/trick animation, and a bunch of board trick/attack animations.
            
        Go along a often downhill course, jump over shit, grind stuff, bomb hills.
        Do tricks to kill enemies, also use melee weapons/guns.
            Like a 360 shove it to chop off an enemies head
        Tricks give some sort of power.
            Use that power for special tricks/attacks?
        Enemies and crashing cause damage.
        Have boss battles on a half pipe, or a hill bomb, or a drainage ditch. Any cool spot.
        Kickflip could shoot forward and stick into enemies, then you land on the board again.
        Powersliding into enemies can kill them/knock them back
        Get upgrades to your board
            Higher speed
            Better pop
            Sharper edges for killing
        Have some satanic demon summoning shit too
        Have a classic skate house as your "base"
        Falling down a hole puts you in a short minigame in hell.
            If you win you pop back out of the hole, if not you die.
            Could be multiple minigames.


    ----------------------------------------------------------------------------------------------------------------------------


    Controls:

        Mouse Right - Weapon
        Mouse Left - Push
        Mouse Middle - Powerslide
        Mouse Position - Aim Gun?
        Mouse Wheel - Change Weapon

        Space - Ollie
            Hold to build up higher ollie, release to jump
        WASD - Tricks, together with Space
            Combos of WASD also, use other keys too maybe. Want to keep it simple.
            Don't need too many tricks, not trying to be Tony Hawk
            Each trick should have a unique attack/effect
                Shove its - Slice
                Kickflip - Stab
                Impossible - Uppercut Slap
                Pogo - On their heads. Could chain for combos. 
            Can chain tricks together or with each other
                ex: Impossible, pogo, pogo, shove it. Or whatever.

        L Shift + other keys - Grinds
        
        Manual/Nose Manual?
        Boneless? L Shift + Space?
        


















------------------------------------------------------------------------------------------------------------------------------*/}