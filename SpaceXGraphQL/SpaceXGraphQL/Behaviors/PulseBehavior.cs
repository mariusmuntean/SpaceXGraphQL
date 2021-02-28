using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SpaceXGraphQL.Behaviors
{
    public class PulseBehavior : Behavior<View>
    {
        private const string PulsingAnimation = "Pulsing";
        private bool _running = false;
        private bool _isReversed = false;

        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);

            _running = true;
            bindable.Animate(PulsingAnimation,
                d =>
                {
                    var newScale = _isReversed ? 1.0d - d : d;
                    bindable.Scale = newScale.Clamp(0.3, 1.0);
                },
                length: 1000,
                easing: Easing.CubicInOut,
                repeat: () =>
                {
                    _isReversed = !_isReversed;
                    return _running;
                });
        }

        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);

            _running = false;
            bindable.AbortAnimation(PulsingAnimation);
        }
    }
}