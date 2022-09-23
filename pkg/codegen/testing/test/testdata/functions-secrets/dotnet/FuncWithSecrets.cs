// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Mypkg
{
    public static class FuncWithSecrets
    {
        public static Task<FuncWithSecretsResult> InvokeAsync(FuncWithSecretsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<FuncWithSecretsResult>("mypkg::funcWithSecrets", args ?? new FuncWithSecretsArgs(), options.WithDefaults());

        public static Output<FuncWithSecretsResult> Invoke(FuncWithSecretsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<FuncWithSecretsResult>("mypkg::funcWithSecrets", args ?? new FuncWithSecretsInvokeArgs(), options.WithDefaults());
    }


    public sealed class FuncWithSecretsArgs : global::Pulumi.InvokeArgs
    {
        [Input("cryptoKey", required: true)]
        public string CryptoKey { get; set; } = null!;

        [Input("plaintext", required: true)]
        private string? _plaintext;
        public string? Plaintext
        {
            get => _plaintext;
            set => _plaintext = value;
        }

        public FuncWithSecretsArgs()
        {
        }
        public static new FuncWithSecretsArgs Empty => new FuncWithSecretsArgs();
    }

    public sealed class FuncWithSecretsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("cryptoKey", required: true)]
        public Input<string> CryptoKey { get; set; } = null!;

        [Input("plaintext", required: true)]
        private Input<string>? _plaintext;
        public Input<string>? Plaintext
        {
            get => _plaintext;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _plaintext = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public FuncWithSecretsInvokeArgs()
        {
        }
        public static new FuncWithSecretsInvokeArgs Empty => new FuncWithSecretsInvokeArgs();
    }


    [OutputType]
    public sealed class FuncWithSecretsResult
    {
        public readonly string Ciphertext;
        public readonly string CryptoKey;
        public readonly string Id;
        public readonly string Plaintext;

        [OutputConstructor]
        private FuncWithSecretsResult(
            string ciphertext,

            string cryptoKey,

            string id,

            string plaintext)
        {
            Ciphertext = ciphertext;
            CryptoKey = cryptoKey;
            Id = id;
            Plaintext = plaintext;
        }
    }
}
