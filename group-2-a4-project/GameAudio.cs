using Raylib_cs;
using System;
using System.Numerics;

namespace Game10003;

public class GameAudio
{
    Sound boomSound;
    Sound gravitySound;
    Music[] backgroundMusic = new Music[3];

    public void LoadAllAudio()
    {
        backgroundMusic[0] = Audio.LoadMusic("../../../Assets/Audio/music-meatball.mp3");
        backgroundMusic[1] = Audio.LoadMusic("../../../Assets/Audio/music-run.mp3");
        backgroundMusic[2] = Audio.LoadMusic("../../../Assets/Audio/music-upbeat.mp3");

        boomSound = Audio.LoadSound("../../../Assets/Audio/kaboom.wav");
        gravitySound = Audio.LoadSound("../../../Assets/Audio/jump.mp3");
    }

    public void PlayMusic()
    {
        int randomMusic = Random.Integer(0, backgroundMusic.Length);
        Audio.Play(backgroundMusic[randomMusic]);
    }

    public void PlayBoom()
    {
        Audio.Play(boomSound);
    }

    public void PlayGravity()
    {
        Audio.Play(gravitySound);
    }
}
