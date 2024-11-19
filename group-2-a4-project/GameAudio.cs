using Raylib_cs;
using System;
using System.Numerics;

namespace Game10003;

public class GameAudio
{
    Sound boomSound;
    Sound gravitySound;
    Music[] backgroundMusic = new Music[3];

    /// <summary>
    ///     Loads all audio files
    /// </summary>
    public void LoadAllAudio()
    {
        backgroundMusic[0] = Audio.LoadMusic("../../../Assets/Audio/music-meatball.mp3");
        backgroundMusic[1] = Audio.LoadMusic("../../../Assets/Audio/music-run.mp3");
        backgroundMusic[2] = Audio.LoadMusic("../../../Assets/Audio/music-upbeat.mp3");

        boomSound = Audio.LoadSound("../../../Assets/Audio/kaboom.wav");
        gravitySound = Audio.LoadSound("../../../Assets/Audio/jump.mp3");
    }

    /// <summary>
    ///     Plays random song from array
    /// </summary>
    public void PlayMusic()
    {
        int randomMusic = Random.Integer(0, backgroundMusic.Length);
        Audio.Play(backgroundMusic[randomMusic]);
    }

    /// <summary>
    ///     Plays kaboom sound
    /// </summary>
    public void PlayBoom()
    {
        Audio.Play(boomSound);
    }

    /// <summary>
    ///     Plays gravity sound
    /// </summary>
    public void PlayGravity()
    {
        Audio.Play(gravitySound);
    }
}
