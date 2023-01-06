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
            
        Movement
            Have a physics ball rolling as base.
            Have board follow that
            Have leges attached to board and to body
            Body always stays straight
            Make this all work together
            From the ball's contact point with the ground, send out two raycasts. One from half a board length behind, one the same length ahead.
                Raycasts shoot straight down, and where they hit the ground is where you position the boards wheels. 
                Body always stays straight and lined up with center of ball (height changes depending on crouching, jumping, normal, etc.)
                Legs attach to the bottom of torso and where feet go on board.
            
        Comedically gory in general.
        Go along a often downhill course, jump over shit, grind stuff, bomb hills.
        Do tricks to kill enemies, also use melee weapons/guns.
            Like a 360 shove it to chop off an enemies head
        Start with maybe just one trick, then learn more as you progress
            Also upgrade tricks. Start with shove-it, upgrade to 360, 540, 720 etc.
            Same with like double kickflip, double impossible, stomp harder/more air with pogo
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

        W / Swipe Up - Impossible/Uppercut Slap
        A / Swipe Left (Back) - 360 (720, more?) Shove-it/Slice Through Body
        S / Swipe Down - Pogo/Head Bounce/Stab
        D / Swipe Right (Forward) - Kickflip/Stab Into Body (Then land on and yank out)

        L Shift + other keys - Grinds
        
        Manual/Nose Manual?
        Boneless? L Shift + Space?
        


















------------------------------------------------------------------------------------------------------------------------------*/}