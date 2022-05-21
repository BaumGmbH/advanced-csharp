using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp.Events {
	class EventMain {
		public static void Start() {
			var video = new Video { Title = "Video 1" };
			var videoEncoder = new VideoEncoder();
			var mailService = new MainService();

			videoEncoder.VideoEncoded += mailService.OnVideoEncoded;1
			videoEncoder.Encode(video);
		}
	}

	public class MainService {
		public void OnVideoEncoded(object source, EventArgs e) {
			Console.WriteLine("MainService: Sending Mail...");
		}
	}
}
