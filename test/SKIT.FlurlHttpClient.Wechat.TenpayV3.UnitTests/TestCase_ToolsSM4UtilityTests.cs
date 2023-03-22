using System.Text;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ToolsSM4UtilityTests
    {
        [Fact(DisplayName = "测试用例：SM4-GCM 解密")]
        public void TestSM4GCMDecrypt()
        {
            string key = "f09b03a7a1902b5b";
            string nonce = "aae8c2e79c5b";
            string aad = "certificate";
            string cipherText = "fB6kij5HTmN4mXBIu6MaZIjDp8jRt2iziXIGF34yLSHo0Gkt6Y6CgjdWZvCxht2UfC52VbHfeNMS4kOBRtpZ/LO9pIoA/V7Qs/V5RD3iqxYBgbCIdgGNmjJN9mcT7VZbBYLnKAp8PQsbVbmHxmmXTpY/xj+geUuF3ELIhTjLcjOB4UW0/FNUjtM9taYriGwVUKo9cJ+652QkFs3QBerxMzqPEObG3NS2h99WrtV1LmayBN2m9ncJJ8Kjk2oSdn/P+ua2CpqM4G6f8AFeitfdRdS94js3A/6GEZGY8WFHMrslvfc8YMj72MxPJ1qv3zF15BBzEKrRcoZWdywRyXDGPpTIXrlGFOiGzxS07FdekYj5V6qW7pD0wuqVug3fyU5wt+Jx4Yvk8dG2voywkqxFzRQfbTL/Wv0+54a+AFK2HFZjY9oXXgiVHpqPK0fv+meTSMoVyQTbVXwfZvNGm5sROJlfM5tiV6UKRbBUx+/6+39H2unwnItIFIMANKJPiS9x8B3Vkxuc8ZdpZe8owfrL6otEPzWSXsDK0zKYvvK+Mxmb40cZZKiaLzXmsEiVTQ9JJX9ycE6xFiCQTjd91zy5Os7xaY6vLPLegdWCbbOq4bpIpX0vt0RPHLWvG3vyzX6tPiy77z9AxOohd4hqLpiH1nA2Ua3+AjcYRYjU7NA1PnbFThBulH7O1TMFtShpLdlZAGl4op926iZVRYZjGAdfbkLCrHmoggsB15DjFWbNwEuuZzpuX5tcIZLXqxNdOrECrwXAYM6K1HtBC/wDpqlNfFb7LEaKRhv++KHE3K6UXekLpPR5h22ttIMbMAjZrBdjXVA9fagPtB1gmY0fH4j0b8Wd6j6Fj8MjjhirvTmRAZHV0Zq1dqw8QDFELOVE1bczZJ2vUDgGoL5cCNgAsjOCejJCsSe2MWiWQgvM8zmwv2eSKHSsVuQ6E4urovXmVdoEdDdar10juldAVVQ5FfSbtZrNpVmK2EHx2s7rBKySR+KWpf1DXNQWa9YmSzxQH4RrVaUB5OSwqhDyxOH4i9HeNzHsK56y/6tumToKA/QCUp2CqZp++OrLNkgy7n3bx1NN3Qm8uIIWQVT5HKJoI0CmvzuSrHAxQQVTkcZ5dMsUF/RQy0lN8ztuF0yTEqRWl4efUoX8RViGJkTyGkQngjZX4XnH7S4mAuvHFBTGFzFmSGUfxeWO9lIXhPUN1yslWxQBxCmGIp7YGmB9k+8WF8z1OgRaYbCbql7DveTcegNyoZXzfpjF3YJ4AQXuvSlKIwK7qsLEKBwmawxwt2yT0SjWuO41AgpeLH9s2JRLPZ+ZY+1RWPG8a4lfl+fMchIQH8qmULGgaqlzbq7VZmRnmeyYOz75v1mvSqNFijCrnlzB4QZcSNI05ylTtvRE6C/WezeY3dc9uVdBRWp1i8jzm6RhFid40C9SCtxrvbv/O3RjfiwsibZp4JWNbIPBmt08aUn0nMjpoaXcQXPTIDLtiYCziECD0Mlf5mz2DaK0ecltI5CfsFT/Yi0zmrbmOARiOP3zkYiCP8bVcWu2sOyC1HB5Dlf3ak8ver5lOJIq43dIG0++LwwxGzgIiQx5MPdWCs1dKD6cREKNdtyjcW689N6Q0hwC7Lj4od2W6oYe2cOOfp6IriKlYUP//a1lAnBI6xaHcy50YoJud77Et3nCUWWyZLS75fMaqNqG+cioe1arnk/n9vIpibZqOyKbPJvNcbTAimshZZY8BJgeRTbm/Jjaka79WFXKxq9gwnl+jUjuxpEhMlkoRAezH4EGK/hdGjnfSk5L54ppxxEGMLBlpjbEaUA+9mSj5OcSqz1iSHUvI8v9RHVyXFixRXCvv9EHsJew";

            string actualPlain = Utilities.SM4Utility.DecryptWithGCM(key: key, nonce: nonce, aad: aad, cipherText: cipherText);
            string expectedPlain = "-----BEGIN CERTIFICATE-----MIID3DCCAsSgAwIBAgIUGZNrTcamx3sFSJsQli3v9C6gZe8wDQYJKoZIhvcNAQELBQAwXjELMAkGA1UEBhMCQ04xEzARBgNVBAoTClRlbnBheS5jb20xHTAbBgNVBAsTFFRlbnBheS5jb20gQ0EgQ2VudGVyMRswGQYDVQQDExJUZW5wYXkuY29tIFJvb3QgQ0EwHhcNMjAwODAxMDczNTE4WhcNMjUwNzMxMDczNTE4WjBuMRgwFgYDVQQDDA9UZW5wYXkuY29tIHNpZ24xEzARBgNVBAoMClRlbnBheS5jb20xHTAbBgNVBAsMFFRlbnBheS5jb20gQ0EgQ2VudGVyMQswCQYDVQQGDAJDTjERMA8GA1UEBwwIU2hlblpoZW4wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDOAYHqxCqaRzoTIvgVixaYJJvmvHbiczbx5MQ9XL1ITSFxkTsNsk7RKHnO7eBS5imheJgQwd22Ky+XclSe7B4odssu/l/+gHo2gooTYrrCpQrOkpvGMf8R8aI56BQIF+vsomDvVq1NojHV2FqljMwFXzhj2EmU6p6gDv9iL7q1NrfnxFx8iJe4OhIB5Ek4qn1xXxrTUhiULd2vXlbIXhRetZSNcJsLt5Rw7D7c8F+aX2JchfeqsZECwKW7bSjMbVWWC6M9MgkB/aId8P0y7qEiiXFJkfkg1I/E1ud2apopsid5tdCyRRR6+MhhX2EC8S04MN4soUT7haqNNxX2rKHnAgMBAAGjgYEwfzAJBgNVHRMEAjAAMAsGA1UdDwQEAwIE8DBlBgNVHR8EXjBcMFqgWKBWhlRodHRwOi8vZXZjYS5pdHJ1cy5jb20uY24vcHVibGljL2l0cnVzY3JsP0NBPTFCRDQyMjBFNTBEQkMwNEIwNkFEMzk3NTQ5ODQ2QzAxQzNFOEVCRDIwDQYJKoZIhvcNAQELBQADggEBAJyg2z4oLQmPfftLQWyzbUc9ONhRMtfA+tVlVBgtLLKnWuDlsmEntheM07fu84F4pcfs3yHzjD7pAOFbO4Yt1yhQ50DK35sjbRWepPdWJZLlni7KBctcmm0o4zq37oB7vonmBEbFqYs9DaINYOjgI3J25iSBkPVC7dBbvFj2xB0LcIcXipq30tDdC/oUem27MNzwZAt49WthKhw6u3HSkcE5cO4LyYTsJhSyG/7LXwvVMgX4Jyzo0SSiGOU1/beaZssTVI8sTPJVlHWjhNE3Lc2SaAlKGfGwvt0X3cEZEF+7oEZIFTkkAF2JhqfnpR3gST0G8Umq1SaVtCPP/zVI8x0=-----END CERTIFICATE-----";

            Assert.Equal(expectedPlain, actualPlain);
        }
    }
}