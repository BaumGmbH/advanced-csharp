using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdvancedCSharp.Events {
	public class VideoEncoder {

		public delegate void VideoEncodedEventHandler(object source, EventArgs args);
		public event VideoEncodedEventHandler VideoEncoded;

		public void Encode(Video video) {
			Console.WriteLine("Title: " + video.Title);
			Console.WriteLine("Encoding Video...");

			Thread.Sleep(3000); // Encode Video

			OnVideoEncoded();
		}

		protected virtual void OnVideoEncoded() {
			if (VideoEncoded != null) {
				VideoEncoded(this, EventArgs.Empty);
			}
		}
	}
}
