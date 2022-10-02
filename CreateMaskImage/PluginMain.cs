using PEPExtensions;
using PEPlugin;
using System;

namespace CreateMaskImage
{
    public class CreateMaskImage : IPEPlugin
    {
        private bool disposedValue;

        public string Name => "マスク画像を作成";

        public string Version => "1.0";

        public string Description => "CreateMaskImage";

        public IPEPluginOption Option => new PEPluginOption(false, true);

        private FormControl Form { get; set; }

        public void Run(IPERunArgs args)
        {
            try
            {
                Form = Form ?? new FormControl(args);
                Form.Reload();
                Form.Show();
            }
            catch (Exception ex)
            {
                Utility.ShowException(ex);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージド状態を破棄します (マネージド オブジェクト)
                }

                // TODO: アンマネージド リソース (アンマネージド オブジェクト) を解放し、ファイナライザーをオーバーライドします
                // TODO: 大きなフィールドを null に設定します
                disposedValue = true;
            }
        }

        // // TODO: 'Dispose(bool disposing)' にアンマネージド リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします
        // ~Class1()
        // {
        //     // このコードを変更しないでください。クリーンアップ コードを 'Dispose(bool disposing)' メソッドに記述します
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを 'Dispose(bool disposing)' メソッドに記述します
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
