using UnityEngine;
using System.Collections;
using System;

public class Res
{
	private const String resources_dir = "Assets/resources/";
	private const String texture_dir = resources_dir + "textures/";
	private const String audio_dir = resources_dir + "audio/";
	private const String environment_dir = Res.texture_dir + "environment/";
	public static Sprite raindrop = LoadEnvironment("raindrop.png");

	private static Sprite square;
	private static Sprite pixel;

	// Audio
	private static AudioClip blop;
	private static AudioClip levelCompletedSound;
	private static AudioClip loseLifeSound;
	private static AudioClip startNewGameSound;

	public static AudioClip LevelCompletedSound{
		get{
			if(levelCompletedSound == null){
				levelCompletedSound = LoadAudioClip("ting.wav");
			}
			return levelCompletedSound;
		}
	}

	public static AudioClip LoseLifeSound{
		get{
			if(loseLifeSound == null){
				loseLifeSound = LoadAudioClip("blop.mp3");
			}
			return loseLifeSound;
		}
	}

	public static AudioClip StartNewGameSound{
		get{
			if(startNewGameSound == null){
				startNewGameSound = LoadAudioClip("Funny sound 6.mp3");
			}
			return startNewGameSound;
		}
	}

	public static AudioClip Blop{
		get{
			if(blop == null){
				blop = LoadAudioClip("blop.mp3");
			}
			return blop;
		}
	}

	public static Sprite Pixel{
		get{
			if(pixel == null){
				pixel = LoadTexture("texture_pack/pixel.png");
			}
			return pixel;
		}
	}

	public static Sprite Square{
		get{
			if (square == null) {
				square = LoadTexture("texture_pack/square_512.png");
			}
			return square;
		}
	}

	private static Sprite LoadEnvironment(string filename){
		return LoadTexture (environment_dir + filename);
	}
	
	private static Sprite LoadTexture (String filename)
	{		
		return Resources.LoadAssetAtPath<Sprite> (texture_dir + filename);		
	}

	public static AudioClip LoadAudioClip(String filename){
		AudioClip audio = Resources.LoadAssetAtPath<AudioClip> (audio_dir + filename);
		if (audio == null) {
			throw new Exception("File could not be found:" + audio_dir + filename);
		}
		return audio;
	}
}

